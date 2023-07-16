# Isaac Haws Final Project

This program is an inventory tracker for electronic parts. In real life there are so many electronic parts that they cannot all be put into a program in so short of time so I have chosen 4 electronic parts to put in this program. 

Here is a short explination of these parts:
A resistor resists the flow of energy in an electronic circuit. Technically speaking if you have a power source of 5 volts and pass that energy through a resistor, the voltage coming out of the resistor will be less than power source

Unlike a resistor a capacitor steadies the flow of electricity, storing and releasing power very quickly 
to get rid of voltage spikes (rapid changes in voltage) that can destory the circuit. 

The parts are: 
* `Chip Resistor` - This kind of resisitor is very small and is made to be placed in designs that are compact. The size of these resistors are often under a millimeter in length but still have remarkable capabilities
* `Through Hole Resistor` - This kind of resistor is bigger than a chip resistor and is constructed in a different way than a chip resistor. This way of making the resistor provides some different options while completing the same objective
* `Multilayer Ceramic` - Like a chip resistor this part is very small and can be placed in compact designs but adds security to the circuit
* `Aluminum Electronic Capacitor` - This kind of capacitor fuctions the same as the multilayer ceramic capacitor but can handle greater voltage in a circuit


Menu options: 
* `Add item` - Menu option 1 will allow you to add one of the four parts above to a list that will be saved to a file. Since you may not fully understand the concept of these part I will leave you values to input or you can enter in something along those lines

Values for Chip Resistor:
  Manufacturer: USAParts
  Package: 0603
  Tolerance: 0.25%
  Resistance: 45kohms
  Power: 25mW
  Quantity: 45

Values for Through Hole Resistor: 
  Manufacturer: IndiaElectronics
  Package: 0456
  Tolerance: 1.5%
  Resistance: 90ohms
  Power: 30w
  Temperature Coefficient: +-50ppm/℃
  Quantity: 20

Values for Multilayer Ceramic Capacitor:
  Manufacturer: USPart
  Package: 5643
  Tolerance: 0.45%
  Capacitance: 100uf
  Rated Voltage: 100v
  Temperature Coefficient: COH
  Quantity: 
  
Values for Aluminum Electronic Capacitor: 
  Manufacturer: ChinaParts
  Package: 7893
  Tolerance: 0.30%
  Capacitance: 150uf
  Rated Voltage: 80v
  Temperature Coefficient: 
  Operating Temperature: -40℃~+105℃
  Lead Spacing: 3.5mm
  Quantity: 45



* `Remove Item` - Menu option 2 will allow you to remove an item from the list. This will not remove it from the file. You must save your changes for that to happen

* `Edit Quantity` - Menu option 3 allows you to change the value of the quantity variable in each instance the part. When adding a part you will input how many of the parts with the values you input with it to add to the list. This menu option will allow you to add or subtract that amount

* `List items` - By selecting menu option 4, you will display the parts you have in the list.

* `Search Items` - A main part of the program this menu option will allow you to search through the parts in the list for a desired value of that part and display all the parts that have that value

* `Load from File` - This option will load part information and use it to add it to the list

* `Save to File` - This option will save all the parts in the list to filename of your input

* `Quit` - This option will quit the program