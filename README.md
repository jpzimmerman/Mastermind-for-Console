# Mastermind-for-Console

![image](https://github.com/user-attachments/assets/b0da2915-d55b-4c5d-9a04-cf541b6af2ca)



Repository for a text-based console app version of Mastermind, a codebreaking game created in 1970 by Mordecai Meirowitz
<br><br>
Game Rules:
There are two players: an AI 'codemaker' and a human 'codebreaker.' The codemaker will generate a secret code according to parameters set within the appsettings.json file. By default, these parameters are as follows:<br>

- Length of code is 4 digits<br>
- Value of each individual digit is 1 =< digit =< 6<br><br>

Player will have ten (10) chances to guess the secret code, and will receive feedback on the accuracy of their guess after each turn:<br>

- If a given digit in the codebreaker's guess matches a digit in the secret code, and is in the proper position, the feedback string will contain a plus sign (+)<br>
- If a given digit in the codebreaker's guess matches a digit in the secret code, but is not in the proper position, the feedback string will contain a minus sign (-)<br>
- If a given digit in the codebreaker's guess does not match any of the digits in the secret code, then no feedback on that digit will be provided in the string.<br><br>

If a player correctly guesses the secret code, the player is congratulated and the program ends.<br>
If a player fails to guess the secret code, the player is informed of their loss and provided with the secret code.<br><br>

Project specifications:<br>
Language: C#<br>
Application framework: .NET 8<br>
Unit testing framework: xUnit<br><br>

To run application:<br>
1.) Navigate to ./Mastermind/Mastermind<br>
2.) Execute the following command: <strong>dotnet run</strong><br><br>

To run unit tests:<br>
1.) Navigate to ./Mastermind/MastermindTests<br>
2.) Execute the following command: <strong>dotnet test</strong><br><Br>

Please use the Issues tab of this Github repository to report any bugs or any issues with documentation, and I will make sure the work is prioritized.
