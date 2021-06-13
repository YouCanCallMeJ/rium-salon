using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiumSalon.JSClasses
{
    /*
     * JSVisitRecord.cs
     *      Rium Salon Coiffure JSVisitHistory Class
     * Revision history
     *      Junseo Yang, 2021.06.13 Created
     */

    class JSVisitRecord
    {
        #region fields
        static StreamWriter writer;
        static StreamReader reader;
        static string filePath = "ClientVisitRecord.txt", archieve = "archiveVisitRecord.txt";
        #endregion

        #region properties
        // RecordId is a integer type property.
        public int RecordId { get; set; }
        // ClientId is a integer type property.
        public int ClientId { get; set; }
        // ClientName is a string type property.
        public string ClientName { get; set; }
        // Service is a string type property.
        public string Service { get; set; }
        // Worker is a string type property.
        public string Worker { get; set; }
        // Price is a Double type property.
        public Double Price { get; set; }
        // Tips is a Double type property.
        public Double Tips { get; set; }
        // Method is a string type property.
        public string Method { get; set; }
        // GST is a Double type property.
        public Double GST { get; set; }
        // QST is a Double type property.
        public Double QST { get; set; }
        // Total is a Double type property.
        public Double Total { get; set; }
        // Date is a DateTime type property.
        public DateTime Date { get; set; }
        // Start is a DateTime type property.
        public string Start { get; set; }
        // End is a DateTime type property.
        public string End { get; set; }
        // Status is a string type property.
        public string Status { get; set; }
        // Status is a string type property.
        public string SpecialRequest { get; set; }
        #endregion

        #region Get methods
        /// <summary>
        /// JSGetStocks has no parameters and returns a List<XXStock> containing all stocks on file. 
        /// </summary>
        /// <returns></returns>
        public static List<JSVisitRecord> JSGetVisitRecords()
        {
            ValidateFile();
            List<JSVisitRecord> jSVisitRecords = new List<JSVisitRecord>();
            try
            {
                using (reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        jSVisitRecords.Add(JSParse(reader.ReadLine()));
                    }
                }
                return jSVisitRecords;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception on getting Visit Records:\n" + ex.Message);
            }
        }

        /// <summary>
        /// JSGetByRecordId accepts an Integer parameter and returns the XXStock object with a RecordId
        /// equal to the given integer … null if not found.  
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>
        public static JSVisitRecord JSGetByRecordId(int recordId = 0)
        {
            ValidateFile();
            JSVisitRecord jSVisitRecord = null;
            try
            {
                using (reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string record = reader.ReadLine();
                        if (record.StartsWith(recordId.ToString() + "\t"))
                        {
                            jSVisitRecord = JSParse(record);
                            break;
                        }
                    }
                }
                return jSVisitRecord;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception on getting Visit Record by ID:\n" + ex.Message);
            }
        }

        /// <summary>
        /// JSGetByName accepts an string parameter and returns the XXClient object with the Name
        /// equal to the given Name … null if not found.  
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public static List<JSVisitRecord> JSGetVisitRecordsByClientId(int clientId)
        {
            ValidateFile();
            List<JSVisitRecord> jSVisitRecords = new List<JSVisitRecord>();
            try
            {
                using (reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string record = reader.ReadLine();

                        if (record.Substring(record.IndexOf('\t') + 1).StartsWith(clientId.ToString()))
                        {
                            jSVisitRecords.Add(JSParse(record));
                        }
                    }
                }
                return jSVisitRecords;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception on getting Visit Records by Client ID:\n" + ex.Message);
            }
        }

        /// <summary>
        /// JSGetByName accepts an string parameter and returns the XXClient object with the Name
        /// equal to the given Name … null if not found.  
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<JSVisitRecord> JSGetByClientName(string name)
        {
            ValidateFile();
            List<JSVisitRecord> jSVisitRecords = new List<JSVisitRecord>();
            try
            {
                using (reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string record = reader.ReadLine();

                        if (record.Substring(record.IndexOf('\t', record.IndexOf('\t') + 1)).StartsWith(name))
                        {
                            jSVisitRecords.Add(JSParse(record));
                            break;
                        }
                    }
                }
                return jSVisitRecords;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception on getting Visit Records by Name:\n" + ex.Message);
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
                JSVisitRecord jSVisitRecordById = JSGetByRecordId(RecordId);

                // Trim all strings, converting nulls into an empty string.
                ClientName = (ClientName + "").Trim();
                ClientId = int.Parse((ClientId + "").Trim());
                Service = (Service + "").Trim();
                Worker = (Worker + "").Trim();
                Price = Double.Parse((Price + "").Trim());
                Tips = Double.Parse((Tips + "").Trim());
                Method = (Method + "").Trim();
                GST = Double.Parse((GST + "").Trim());
                QST = Double.Parse((QST + "").Trim());
                Total = Double.Parse((Total + "").Trim());
                Date = DateTime.Parse((Date + "").Trim());
                Start = (Start + "").Trim();
                End = (End + "").Trim();
                Status = (Status + "").Trim();
                SpecialRequest = (SpecialRequest + "").Trim();


                // If the RecordId is zero, then you’re adding a new record 
                // otherwise, it’s an update and the given RecordId must be on file
                if (RecordId != 0)
                {
                    if (jSVisitRecordById == null)
                    {
                        errors += $"The Record ID '{RecordId}' is not on the File.\n";
                    }
                }

                // ClientId and ClientName are required, and cannot be just spaces
                if (ClientId + "" == "")
                {
                    errors += "Client ID is required, and cannot be just spaces.\n";
                }
                if (ClientName == "")
                {
                    errors += "Client Name is required, and cannot be just spaces.\n";
                }

                // Price and Minutes cannot be less than zero.
                if (Price < 0)
                {
                    errors += $"The Price '{Price}' cannot be less than zero.\n";
                }
                if (Tips < 0)
                {
                    errors += $"The Tips '{Tips}' cannot be less than zero.\n";
                }
                if (GST < 0)
                {
                    errors += $"The GST '{GST}' cannot be less than zero.\n";
                }
                if (QST < 0)
                {
                    errors += $"The QST '{QST}' cannot be less than zero.\n";
                }
                if (Total < 0)
                {
                    errors += $"The Total '{Total}' cannot be less than zero.\n";
                }

                if (Date + "" == "")
                {
                    errors += "Date is required, and cannot be just spaces.\n";
                }
                if (Start + "" == "")
                {
                    errors += "Start is required, and cannot be just spaces.\n";
                }
                if (End + "" == "")
                {
                    errors += "End is required, and cannot be just spaces.\n";
                }

                if (Status == "")
                {
                    errors += "Status is required, and cannot be just spaces.\n";
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
        /// JSAdd is an instance method that accepts an XXStock object and, if it passes all edits: 
        /// </summary>
        /// <param name="jSVisitRecord"></param>
        // The Add method in the class will assign a unique value.
        public void JSAdd(JSVisitRecord jSVisitRecord)
        {
            try
            {
                ValidateFile();
                JSEdit();
                List<int> recordIdList = new List<int>();
                List<JSVisitRecord> jSVisitRecords = JSGetVisitRecords();

                // if list is empty stockId is 1
                if (jSVisitRecords.Count == 0)
                {
                    jSVisitRecord.RecordId = -2;
                }
                // else list is not empty stockId is the minimum stockId - 1
                else
                {
                    foreach (var record in jSVisitRecords)
                    {
                        recordIdList.Add(record.RecordId);
                    }
                    jSVisitRecord.RecordId = recordIdList.Min() - 1;
                }

                // It adds the record to the file.
                using (writer = new StreamWriter(filePath, append: true))
                {
                    writer.WriteLine(jSVisitRecord.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception trying to add new Visit Record:\n" + ex.Message);
            }
        }

        /// <summary>
        /// JSUpdate is an instance method that accepts an XXStock object and replaces the current
        /// record with the same RecordId, if the updated record passes the edits.
        /// </summary>
        /// <param name="jSVisitRecord"></param>
        // JSUpdate accepts an XXStock object and replaces the current record with the same RecordId,
        // if the updated record passes the edits.
        public void JSUpdate(JSVisitRecord jSVisitRecord)
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

                // find the record that starts with the given RecordId 
                // if a record doesn't start with the given RecordId, just leave it
                // if a record starts with the given stockId, then add updated new values to the variable record.
                using (reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        if (record.StartsWith(jSVisitRecord.RecordId + "\t"))
                        {
                            records.Add(jSVisitRecord.ToString());
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
                    throw new Exception($"RecordId is not on file: '{RecordId}'");
                }
                else
                {
                    File.Delete(archieve);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception updating the Visit Record:\n" + ex.Message);
            }
        }

        // JSDelete accepts a string and removes the record with the given RecordId from the file. 
        public void JSDelete(string recordId)
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
                        if (record.StartsWith(recordId + "\t"))
                        {
                            found = true;
                        }
                        else
                        {
                            records.Add(record);
                        }
                    }
                }

                // update the file with the records that the given stockId record is deleted.
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
                    throw new Exception($"RecordId is not on file: '{RecordId}'");
                }
                else
                {
                    File.Delete(archieve);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception deleting the stock:\n" + ex.Message);
            }
        }
        #endregion

        #region utilities like ToString, JSParse, ValidateFile
        /// <summary>
        /// ToString overrides the ToString() method that your class inherited from Object
        /// It returns a single string containing all the object’s properties, delineated
        /// so the string can be parsed back into an JSVisitRecord object later.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{RecordId}\t{ClientId}\t{ClientName}\t{Service}\t{Worker}\t{Price}\t{Tips}\t{Method}\t{GST}\t{QST}\t{Total}\t{Date}\t{Start}\t{End}\t{Status}\t{SpecialRequest}";
        }

        /// <summary>
        /// JSParse is a class (static) method that accepts a string parameter and returns
        /// an object of the XXClient class.
        /// The string is a record from the record file containing a record object’s properties.
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public static JSVisitRecord JSParse(string record)
        {
            string[] fields = record.Split(new char[] { '\t', '\r', '\n' });
            JSVisitRecord jSVisitRecord = new JSVisitRecord()
            {
                RecordId = int.Parse(fields[0]),
                ClientId = int.Parse(fields[1]),
                ClientName = fields[2],
                Service = fields[3],
                Worker = fields[4],
                Price = Double.Parse(fields[5]),
                Tips = Double.Parse(fields[6]),
                Method = fields[7],
                GST = Double.Parse(fields[8]),
                QST = Double.Parse(fields[9]),
                Total = Double.Parse(fields[10]),
                Date = DateTime.Parse(fields[11]),
                Start = fields[12],
                End = fields[13],
                Status = fields[14],
                SpecialRequest = fields[15]
            };
            return jSVisitRecord;
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
