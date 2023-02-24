using ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp.Services
{
    internal class CsvServices
    {
        public void ImportData(string pathImportCsvFile)
        {
            if (!File.Exists(pathImportCsvFile)) 
                throw new FileNotFoundException($"File does not exist in the specified path: {pathImportCsvFile}");

            try
            {
                // Read csv file and write to string list
                var importedLines = new List<string>();
                using (var streamReader = new StreamReader(pathImportCsvFile))
                {
                    while (!streamReader.EndOfStream)
                    {
                        var line = streamReader.ReadLine();
                        if (!string.IsNullOrEmpty(line)) importedLines.Add(line);
                    }
                }

                List<ImportedObject> importedObjects = new List<ImportedObject>();
                for (int i = 0; i <= importedLines.Count; i++)
                {
                    var values = importedLines[i].Split(';');
                    var importedObject = new ImportedObject();
                    importedObject.Type = values[0];
                    importedObject.Name = values[1];
                    importedObject.Schema = values[2];
                    importedObject.ParentName = values[3];
                    importedObject.ParentType = values[4];
                    importedObject.DataType = values[5];
                    importedObject.IsNullable = values[6];
                    importedObjects.Add(importedObject);
                }


            }
            catch (Exception ex) {
                var x = 1;
            }
        }

        
    }
}
