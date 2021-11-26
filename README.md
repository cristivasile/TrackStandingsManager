
# TrackStandingsManager
### Summary
TSM is used for creating and managing vehicular leaderboards. How is it different from most leaderboard apps? The main focus of this app is comparing the vehicles rather than the authors of the times. You can filter leaderboards by car brands and categories (ex: show only sedans), or list all the vehicles and sort them by the average positions inside the competitions. 

For questions, suggestions and bug reports please e-mail TrackStandingsManager@gmail.com.

### Quick tutorial
Table of contents:
- [Vehicle creation](#vehicle-creation)
- [Competition creation](#competition-creation)
- [Competitor creation](#competitor-creation)
- [Using the competition manager](#using-the-competition-manager)
- [Using the vehicle manager](#using-the-vehicle-manager)
- [Random choice window](#random-choice-window)

### Vehicle creation
Firstly, let's navigate to the vehicle insertion window.

Main menu -> Vehicle Manager -> Add new
![](https://i.postimg.cc/SKYzqMP8/1.png)
This will open the following window:

![](https://i.postimg.cc/rp4z7LdN/2.png)

Let's go through all the fields in this window:

- **Brand and model** - pretty self-explanatory;
- **Category** - you can use this to group vehicles by whatever criterion you want. The app has a few default categories but you can add as many as you want, or delete them using the red remove button. 
Example: sedan/coupe/hatchback, 3 wheeler/4 wheeler, old/new;
- *Image (optional)* - an image of the vehicle that you can paste from the clipboard. Tip: you can use Windows + Shift + S to take a quick screenshot.

I went ahead and filled the fields. I didn't want to use the default categories, so I added a new one (just write it in the field and it will be created along with the vehicle). Now all that's left to do is press add.

![](https://i.postimg.cc/CxV2bGGM/3.png)

It worked! (probably)
![](https://i.postimg.cc/zvVsPqvJ/4.png)

### Competition creation
Now that we have a vehicle, we need a competition for it to partake in. Same as before, let's go to the creation window.

Main menu -> Competition Manager -> Add competition
![](https://i.postimg.cc/k4yLZ5WS/5.png)

This will open the following window:

![](https://i.postimg.cc/fRGFRPsB/6.png)

Let's go through all the fields in this window:

- **Name** - competition name;
- *Description (optional)* - field where you can describe the competition as thoroughly as you desire;
- *Image (optional)* - an image of the competition that you can paste from the clipboard. Tip: you can use Windows + Shift + S to take a quick screenshot.
- **Score type** - Indicates the scoring type of the competition. A competition can be ranked by either points or timings;
    - If the competition is scored by timings, you can choose from 3 formats: SS.mmm, MM:SS.mmm and HH:MM:SS.mmm
- **Sort** - Indicates the ordering type of the competition.;
**Example:** if you are measuring a jump distance, you need the competition to be scored by descending points; if you are measuring track times, you'd want ascending timings.

Be careful! Unlike vehicles, a competition can not be edited after creation. I have added the following competition:

![](https://i.postimg.cc/zffb2q3c/7.png)

### Competitor creation
Having a competition is pointless until we actually add some competitors. Let's do that! 
In the competition manager, select the desired competition using the underlined drop-down and press on new entry.

![](https://i.postimg.cc/sDdRTKvF/8.png)

Oh no, I just realized I forgot to add another vehicle! Good thing I can press on the "new" button and open the vehicle creation window from here.
![](https://i.postimg.cc/6q7nTtCP/9.png)

Let's talk about the window's fields:

- **Vehicle** - A new entry must contain a vehicle. There are 3 ways of selecting a vehicle:
    - choosing one from the drop-down
    - writing a name in the drop-down and pressing "Search"; *you must write the full "Brand" + "Model" of the vehicle in the input*
    Example: If we search for "Normal Kaar" or "Normâl Kaa" the vehicle will not be found.
    - writing a name in the drop-down and pressing down-arrow on your keyboard; *this will select the first vehicle found that contains your input*
    Example: If we have 2 vehicles, "Brand Model1" and "Brand Model2" and we use this method to search for "Brand M" the vehicle resulted will be "Brand Model1".
 - *Author* (optional) - The author of this entry;
 - **Score** - this field can be of two types, depending on the competition.
     - **using points** - score must be a rational number;
     - **using timing** - timing must contain at least one digit. It can have whatever format you want, the program takes into account just the digits. If you enter less digits than needed, the timing will be automatically padded with zeroes. This is done so you can copy timings from other sources without needing to worry about formatting.
     Examples of valid timing inputs: (for "MM:SS.mmm")
        - 2 -> 20:00.000
        - 02/3 -> 02:30.000
        - 12 15 345 -> 12:15.345
        - 12:15.345 -> 12:15.345
        - 12/15/345 -> 12:15.345
        - **12**afsdgasg**15**gdfsh**345** -> 12:15.345

I have added the following entry:
![](https://i.postimg.cc/SKfs4str/10.png)

### Using the competition manager
I have added some more vehicles and competitors in order to better show off this window's functionality.

![](https://i.postimg.cc/Dy11v9pC/11.png)
#### Let's start with the menu bar.
- Delete - deletes the current competition;
- Reset - resets the window to it's initial state;
- Filter by - can be used to exclude any brands or categories from the current leaderboard;
  ![](https://i.postimg.cc/K8LpyptF/12.png)

Example: I have decided that I don't want to include "Tuned" vehicles in my leaderboard. To exclude them, I must press on the "Category" button in the "Filter by" section. That will open the following window:
![](https://i.postimg.cc/8C7RSj2v/13.png)

All I have to do next is uncheck "Tuned" and press the "Filter" button. The result:
![](https://i.postimg.cc/tC7CDWWF/14.png)
#### Edit and delete buttons
Each entry in the leaderboard has these two buttons:

![](https://i.postimg.cc/GmGRSQ2T/15.png)
The left one is called the "edit" button and can be used to edit the vehicle, author and/or score of a competitor.
The left one is the "delete" button. *You can probably guess what it does.*
### Using the vehicle manager
By default, the vehicles are sorted alphabetically and pictures are not shown.

My current list of vehicles:
![](https://i.postimg.cc/W47hxj3Z/16.png)
#### Displaying pictures
You must check the "show pictures" checkbox in order to display the vehicles' pictures.
#### Sorting
There are two types of sorting:

- **name** (default) - vehicles are sorted aphabetically by brand and then by model;
- **average position** - the right-most field of every vehicle is called "average position". It is the average of all the vehicles' entries in every competition. It can be used to rank vehicles by performance.
To sort the vehicles by average position, go to the menu bar and select "Average position" in the "Sort by" section.
![](https://i.postimg.cc/Hk3kYzwc/17.png)

#### Filtering
Filtering works the same way as in [Competition manager](#lets-start-with-the-menu-bar.)

#### Here is the list of vehicles (with pictures) sorted by average position and filtered to only show "GenericBrand":
![](https://i.postimg.cc/xCj0WzJG/18.png)
### Random choice window
You can get here from "Main menu -> What should I play?"
This is what the window looks like:
![](https://i.postimg.cc/rps0vsdr/19.png)

I don't think that explaining what the checkboxes do is necessary. This is how the window looks with them checked:
![](https://i.postimg.cc/W1XqWg4V/20.png)
