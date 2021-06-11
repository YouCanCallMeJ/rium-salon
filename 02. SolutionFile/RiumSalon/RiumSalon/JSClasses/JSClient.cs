using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiumSalon.JSClasses
{
    /*
     * JSClient.cs
     *      Rium Salon Coiffure JSClient Class
     * Revision history
     *      Junseo Yang, 2021.06.11 Created
     */

    class JSClient
    {
        #region fields
        static StreamWriter writer;
        static StreamReader reader;
        static string filePath = "Client.txt", archieve = "archive.txt";
        #endregion

        #region properties
        // ClientId is a integer type property.
        public int ClientId { get; set; }
        // ClientName is a string type property.
        public string ClientName { get; set; }
        // ClientPhone is a string type property.
        public string ClientPhone { get; set; }
        // ClientEmail is a string type property.
        public string ClientEmail { get; set; }
        // ClientNotes is a string type property.
        public string ClientNotes { get; set; }
        #endregion

        #region Get methods
        /// <summary>
        /// JSGetClients has no parameters and returns a List<JSClient> containing all Clients on file. 
        /// </summary>
        /// <returns></returns>
        public static List<JSClient> JSGetClients()
        {
            ValidateFile();
            List<JSClient> clients = new List<JSClient>();
            try
            {
                using (reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        clients.Add(JSParse(reader.ReadLine()));
                    }
                }
                return clients;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception on getting clients:\n" + ex.Message);
            }
        }

        /// <summary>
        /// JSGetByClientId accepts an Integer parameter and returns the XXClient object with a ClientId
        /// equal to the given integer … null if not found.  
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public static JSClient JSGetByClientId(int clientId)
        {
            ValidateFile();
            JSClient client = null;
            try
            {
                using (reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string record = reader.ReadLine();
                        if (record.StartsWith(clientId.ToString() + "\t"))
                        {
                            client = JSParse(record);
                            break;
                        }
                    }
                }
                return client;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception on getting client by ID:\n" + ex.Message);
            }
        }

        /// <summary>
        /// JSGetByName accepts an string parameter and returns the XXClient object with the Name
        /// equal to the given Name … null if not found.  
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<JSClient> JSGetByName(string name)
        {
            ValidateFile();
            List<JSClient> clients = new List<JSClient>();
            try
            {
                using (reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string record = reader.ReadLine();

                        if (record.Substring(record.IndexOf('\t') + 1).StartsWith(name))
                        {
                            clients.Add(JSParse(record));
                            break;
                        }
                    }
                }
                return clients;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception on getting client by Name:\n" + ex.Message);
            }
        }
        #endregion

        #region methods like JSEdit, JSAdd, JSUpdate, JSDelete
        /// <summary>
        /// JSEdit is an instance method that performs the following validations on the current object 
        /// If there are any error or exception messages, throw them all at once in an exception.
        /// </summary>
        public void JSEdit()
        {
            // Initialize an empty string to collect all the error messages
            string errors = "";
            try
            {
                ValidateFile();
                JSClient clientById = JSGetByClientId(ClientId);
                List<JSClient> clientsByName = JSGetByName(ClientName);

                // Trim all strings, converting nulls into an empty string.
                ClientName = (ClientName + "").Trim();
                ClientPhone = (ClientPhone + "").Trim();
                ClientEmail = (ClientEmail + "").Trim();
                ClientNotes = (ClientNotes + "").Trim();

                // If the ClientId is zero, then you’re adding a new record 
                // otherwise, it’s an update and the given ClientId must be on file
                if (ClientId != 0)
                {
                    if (clientById == null)
                    {
                        errors += $"The Client ID '{ClientId}' is not on the File.\n";
                    }
                }

                // ClientName is required, and cannot be just spaces
                if (ClientName == "")
                {
                    errors += "Name is required, and cannot be just spaces.\n";
                }

                // Validate Name: Name must be unique on file.
                // The user cannot add a duplicate name, nor can they update an existing record to create a duplicate.
                // if clientById == null (clientId == 0), it is add
                if (clientById == null)
                {
                    if (clientsByName.Count > 0)
                    {
                        errors += $"The Name '{ClientName}' is already on the File.\n";
                    }
                }
                // else if clientById != null, it is update
                else
                {
                    // if another record already has the name, it is error.
                    // But if the record is the record that we are updating, it is not an error.
                    foreach (var client in clientsByName)
                    {
                        if (client.ClientName == ClientName)
                        {
                            if (client.ClientId != ClientId)
                            {
                                errors += $"The Name '{ClientName}' is already on the File.\n";
                            }
                        }

                    }
                }

                if (errors != "")
                {
                    throw new Exception(errors);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// JSAdd is an instance method that accepts an XXClient object and, if it passes all edits: 
        /// </summary>
        /// <param name="client"></param>
        // The Add method in the class will assign a unique value.
        public void JSAdd(JSClient client)
        {
            try
            {
                ValidateFile();
                JSEdit();
                List<int> clientIdList = new List<int>();
                List<JSClient> clients = JSGetClients();

                // if list is empty clientId is 1
                if (clients.Count == 0)
                {
                    client.ClientId = 1;
                }
                // else list is not empty clientId is the maximum clientId + 1
                else
                {
                    foreach (var record in clients)
                    {
                        clientIdList.Add(record.ClientId);
                    }
                    client.ClientId = clientIdList.Max() + 1;
                }

                // It adds the record to the file.
                using (writer = new StreamWriter(filePath, append: true))
                {
                    writer.WriteLine(client.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception trying to add new record:\n" + ex.Message);
            }
        }

        /// <summary>
        /// JSUpdate is an instance method that accepts an XXClient object and replaces the current
        /// record with the same ClientId, if the updated record passes the edits.
        /// </summary>
        /// <param name="client"></param>
        // JSUpdate accepts an XXClient object and replaces the current record with the same ClientId,
        // if the updated record passes the edits.
        public void JSUpdate(JSClient client)
        {
            string record = "";
            List<string> records = new List<string>();
            Boolean found = false;
            try
            {
                ValidateFile();
                JSEdit();
                if (File.Exists(archieve))
                {
                    File.Delete(archieve);
                }

                // Back-up
                File.Copy(filePath, archieve);

                // find the record that starts with the given clientId 
                // if a record doesn't start with the given clientId, just leave it
                // if a record starts with the given clientId, then add updated new values to the variable record.
                using (reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        if (record.StartsWith(client.ClientId + "\t"))
                        {
                            records.Add(client.ToString());
                            found = true;
                        }
                        else
                        {
                            records.Add(record);
                        }
                    }
                }

                // write file with records that includes updated value
                using (writer = new StreamWriter(filePath, append: false))
                {
                    foreach (var item in records)
                    {
                        writer.WriteLine(item);
                    }
                }

                // if update is unsucessful with the reason that there isn't the given sotckId on the file.
                if (!found)
                {
                    throw new Exception($"ClientId is not on file: '{ClientId}'");
                }
                else
                {
                    File.Delete(archieve);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception updating the client:\n" + ex.Message);
            }
        }

        // JSDelete accepts a string and removes the record with the given ClientId from the file. 
        public void JSDelete(string clientId)
        {
            string record = "";
            List<string> records = new List<string>();
            Boolean found = false;
            try
            {
                ValidateFile();
                if (File.Exists(archieve))
                {
                    File.Delete(archieve);
                }

                File.Copy(filePath, archieve);

                using (reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        if (record.StartsWith(clientId + "\t"))
                        {
                            found = true;
                        }
                        else
                        {
                            records.Add(record);
                        }
                    }
                }

                // update the file with the records that the given clientId record is deleted.
                using (writer = new StreamWriter(filePath, append: false))
                {
                    foreach (var item in records)
                    {
                        writer.WriteLine(item);
                    }
                }

                // if delete is unsucessful with the reason that there isn't the given sotckId on the file.
                if (!found)
                {
                    throw new Exception($"ClientId is not on file: '{ClientId}'");
                }
                else
                {
                    File.Delete(archieve);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception deleting the client:\n" + ex.Message);
            }
        }
        #endregion

        #region utilities like ToString, JSParse, ValidateFile
        /// <summary>
        /// ToString overrides the ToString() method that your class inherited from Object
        /// It returns a single string containing all the object’s properties, delineated
        /// so the string can be parsed back into an JSClient object later.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{ClientId}\t{ClientName}\t{ClientPhone}\t{ClientEmail}\t{ClientNotes}";
        }

        /// <summary>
        /// JSParse is a class (static) method that accepts a string parameter and returns
        /// an object of the XXClient class.
        /// The string is a record from the client file containing a client object’s properties.
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public static JSClient JSParse(string record)
        {
            string[] fields = record.Split(new char[] { '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            JSClient client= new JSClient()
            {
                ClientId = int.Parse(fields[0]),
                ClientName = fields[1],
                ClientPhone = fields[2],
                ClientEmail = fields[3],
                ClientNotes = fields[4]
            };
            return client;
        }

        /// <summary>
        /// ValidateFile is a private static void method that checks whether the file exists or not.
        /// </summary>
        private static void ValidateFile()
        {
            if (!File.Exists(filePath))
            {
                if (File.Exists(archieve))
                {
                    File.Move(archieve, filePath);
                }
                else
                {
                    File.Create(filePath).Dispose();
                }
            }
        }
        #endregion
    }
}
