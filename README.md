# NFL Tracker APP
Created By: Bruce Brown

## About

A C# WinForm application to display data for the current National Football League (NFL) season, teams, and players by using the API-AMERICAN-FOOTBALL (1.4.7) API from [API-SPORTS](https://v1.american-football.api-sports.io). The API key used is associated with the Mega plan tier option that allows up to 150,000 calls to the API each day, but a new developer would need to get their own key from API-Sports. There is an option to view a list of teams by division or conference, which allows the user to click on the team's image to get the team’s data. On the team form there is information about the team and a few stats, as well as buttons to get the current roster, schedule, or current game data. There is error handling for when the API returns and error and when there is no data available for a team or player selected. Datagridviews are used to display most of the data and statistics received from the API calls. There is a help menu that provides information to the user about how to use the different forms.

## API Key

The API Key is stored in the NFLKey.cs class, which is required for the application to run. That class variable is currently blank due to this project being on GitHub. I eventually plan to update this application to use a Key Vault to no longer have to house the key within the application.

## API Documentation
The documentation for the API-Sports NFL API can be found at [API-SPORTS](https://api-sports.io/documentation/nfl/v1).

## Licensing
The code for this application is released to the public domain under the [Creative Commons CC0 License](https://creativecommons.org/publicdomain/zero/1.0/). I do not own any of the rights to the NFL pictures and logos, as well as I do not own any of the data retrieved from the API-Sports NFL API. All images and data belong to their creators and owners. Some data may also be copyrighted or restricted in some countries. What you do with it is your own responsibility.
