using System;


public class ManageFile {
    private string _filename;
    private string[] _lines;
    private string _action;
    private string _itemType;


    public ManageFile(List<Part> items, string action) {
        //Get file name
        Console.WriteLine();
        Console.Write("What is the name of the file? ");
        _filename = Console.ReadLine();
        
        _action = action;

        if(_action == "save") {
            using (StreamWriter outputFile = new StreamWriter(_filename))
            {    
                Console.Write("Saving");
                DisplayDots();
                foreach (Part item in items)
                {
                    outputFile.WriteLine(item.GetInfo());
                }
                
                Console.WriteLine("The information has been saved!");
            }
        }

        
        else if(_action == "load") {
            Console.Write("Loading");
            DisplayDots();

            _lines = System.IO.File.ReadAllLines(_filename);

            string manufacturer;
            string package;
            string tolerance;

            string resistance;
            string powerWatts;
            int quantity;

            string tempCoefficient;

            foreach (string line in _lines) {
                string[] splitLine = line.Split(",");

                _itemType = splitLine[0];
                manufacturer = splitLine[1];
                package = splitLine[2];
                tolerance = splitLine[3];

                if(_itemType == "ChipResistor") {
                    resistance = splitLine[4];
                    powerWatts = splitLine[5];
                    quantity = int.Parse(splitLine[6]);

                    items.Add(new ChipResistor(manufacturer, package, tolerance, resistance, powerWatts, quantity));
                }

                else if(_itemType == "ThroughHoleResistor") {
                    resistance = splitLine[4];
                    powerWatts = splitLine[5];
                    tempCoefficient = splitLine[6];
                    quantity = int.Parse(splitLine[7]);

                    items.Add(new ThroughHoleResistor(manufacturer, package, tolerance, resistance, powerWatts, tempCoefficient, quantity));
                }

                string capacitance;
                string ratedVoltage;

                else if(_itemType == "MultilayerCeramic") {
                    capacitance = splitLine[4];
                    ratedVoltage = splitLine[5];
                    tempCoefficient = splitLine[6];
                    quantity = int.Parse(splitLine[7]);

                    items.Add(new MultilayerCeramic(manufacturer, package, tolerance, capacitance, ratedVoltage, tempCoefficient, quantity));
                }

                else if(_itemType == "AluminumElectronic") {
                    capacitance = splitLine[4];
                    ratedVoltage = splitLine[5];
                    tempCoefficient = splitLine[6];
                    string operatingTemp = splitLine[7];
                    string leadSpacing = splitLine[8];
                    quantity = int.Parse(splitLine[9]);

                    items.Add(new AluminumElectronic(manufacturer, package, tolerance, capacitance, ratedVoltage, tempCoefficient, operatingTemp, leadSpacing, quantity));
                }
            }
        }
    }


    public void DisplayDots() {
        for (int i = 0; i < 4; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}