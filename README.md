This is a quick overview of the program and how to use it.

This program is designed to synchronise music to tidal waves or the water level of a body of water, see this post on Reddit that more accurately describes it:
https://www.reddit.com/r/csharp/comments/o36myc/247_natural_ambient_and_electronic_music/

To do this, it uses the NOAA CO-OPS API: https://api.tidesandcurrents.noaa.gov/api/prod/
The textboxes labeled Datum, Station ID, and Units all correspond to the variables laid out in that website.

To start, a station on the Detroit river is used as an example. The Datum, Station ID, Units, and heights are already inputted. 

In this scenario, when water height is between 574.69 and 575.74 in the river, it chooses music from the “Very Slow” directory or link. When it is between 575.74 and 575.77, it chooses from the “Slow” directory or link, and so on.

The textboxes below the “choose directory” buttons are all meant to be inputs for links, which will open in your default browser. It will simulate pressing the spacebar to play on whatever website you link. Once it is opened, the program will not play anything again until it detects that there is no music being played, so be sure you don’t have anything set on a loop or have any extended periods of silence.

The choose directory buttons all bring up a prompt for you to choose the corresponding folder to use in each category. 

Please keep in mind I am quite terrible at coding, so expect a bit of a learning curve, and plenty of bugs.

Additionally, I will be posting 24 hours of royalty free (ish) music for you to use, including original St.GIGA archives in the future, however this is all I have for now.

Thanks for reading, and good luck!
