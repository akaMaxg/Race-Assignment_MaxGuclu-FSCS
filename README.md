
# Car-race assignment, Max Guclu, Chas Academy Fullstack .NET

## Fullstack-NET_MaxG_ChasAcademy22 Car-Race
Welcome to the individual assignment The Car-Race, in C#
This project is to be able to write, manage and present the progress of asynchronous threads in a console program.

## Prerequisites
To the project, you will need the following software installed on your machine:
* .NET Core

## Running the program
To run the project, follow these steps:
 - Open a terminal window and navigate to the root directory of the project.
 - Run the following command to start the application: dotnet run
 - Alternatively use an IDE to run it

## Usage
Once the application is running, you can use it by following the on-screen prompts.

## Contributions & Feedback
If you would like to contribute to this project, please fork the repository and submit a pull request. All contributions, and feedbacks are welcome and appreciated!

### The program
- The program runs on three main models, Car, Events and Track
- 1. A Car object This class allows for the management of individual race-cars, E.g. Speed and Name.
- 2. A Evemt object which carries the properties which ocurring incidents may inflict upon the cars
- 3. A Track object for scaleability and keeping track of who finishes first.

- The program revolves around the function "Racer" under Race-class. This first ensures that the loop progresses as long as the inputed car-object has not exceeded the length of the track.
In which, a timer starts and an if statements randoms an event every 30s. However, the cars distance is updated every second to be able to distinguish who finished first.
- Services folder with Race class also contains pre-race text and logic to ensure that a user can check for race status at will. The asynch functions, and so on.
- Utilities folder contains classes that are more back-end. it holds functions to instansiate the objects, count down timers and so on.

#### Overall
In general, the entire program is divided into Models, Services and Utility. This is to make the code accessible and easy to maintain. 

## The requirements listed for the assignment below and checkbox for backlog-> done.   

#### [X] Varje bil ska vara ett objekt, varje bil ska ha ett namn och minst två bilar i denna tävling   
#### [X] Tävlingen går ut på att bilarna ska köra en sträcka på exempelvis 10 km   
#### [X] Alla bilar ska börja på 0 km   
#### [X] Alla bilar har en hastighet i grunden på exempelvis 120 km/h. Ingen bil är långsammare eller snabbare än de andra från början.   
#### [X] Bilarna behöver inte accelerera. De kommer direkt upp i sin hastighet.   
#### [X] Varje Bil-objekt ska köra i en egen tråd   


### [X] Det ska finnas några slumpmässiga händelser som kan inträffa för en bil.      
### Slut på bensin	1/50	Behöver tanka, stannar 30 sekunder   
### Punktering	2/50	Behöver byta däck, stannar 20 sekunder   
### Fågel på vindrutan	5/50	Behöver tvätta vindrutan, stannar 10 sekunder   
### Motorfel	10/50	Hastigheten på bilen sänks med 1km/h   
#### [X] Var 30e sekund ska det för varje bil slumpas fram en händelse. Bara en händelse kan inträffa per gång.   
   
#### [X] Alla bilar ska starta samtidigt   
#### [X] Skriva ut i konsolen när bilarna startar   
#### [X] Skriv ut i konsolen när en bil får ett problem. Skriv vilken bil och vilket problem.    
#### [X] Skriv ut när en bil kommer i mål. Om det är den första ska det också skrivas ut att den vann!   
#### [X] Användaren ska kunna välja att få läget i tävlingen utskrivet på kommando.    
#### [X] När detta görs ska alla bilar och hur långt de kommit skrivas ut samt deras hastighet.
