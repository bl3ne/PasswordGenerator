# PasswordGenerator

A small .NET MAUI app that generates random passwords with a custom length and lets you copy them to the clipboard with a single click. 

## Features

- Generate a random password with a user-defined length.
- Uses a mixed character set: uppercase, lowercase, numbers, and symbols `!@#$%^&*_?-:;`. 
- Shows a status label with how many times the **Generate Password** button was clicked. 
- Brutalist-style UI built with XAML (hard shadows, flat frames, bold labels). 
- Copy the generated password to the clipboard with one button. 

## Tech stack

- C# (.NET / .NET MAUI) 
- XAML (MAUI `MainPage`) 
- Visual Studio 2022 

## Getting started

1. Download the project as a **ZIP** from GitHub. 
2. Extract the **ZIP** somewhere on your PC.
3. Open the `.sln` file in **Visual Studio 2022**.

Or:

1. Clone this repository: `git clone https://github.com/bl3ne/PasswordGenerator.git`

2. Open the solution (`.sln`) in **Visual Studio 2022**. 
3. Make sure the **.NET Multi-platform App UI development** workload is installed.
4. Set the MAUI project as **Startup Project** if needed.
5. Press **F5** or click **Start** to run the app in Debug mode.  

## Usage

1. Run the application from Visual Studio or from your build output. 
2. In the `LENGTH_INPUT` field, type the desired password length (an integer, e.g. `16`).
3. Click **GENERATE PASSWORD >**. 
4. On each click:
- A new random password is generated using the character set defined in the code. 
- The status label updates with how many times you clicked the button. 

5. Click **COPY PASSWORD** to copy the current password to your clipboard. 

If the length field is empty or not a valid integer, an alert is shown explaining the error. 
If there is no valid password yet, the app shows an alert instead of copying.

## Project structure

- `MainPage.xaml`: defines the UI (brutalist card, header label, length input, buttons, status label). 
- `MainPage.xaml.cs`: handles button clicks, validates the length, generates the password with `Random`, and copies to clipboard. 

## Possible improvements

- Let the user choose which character groups to include (letters, digits, symbols). 
- Option to avoid ambiguous characters like `O/0`, `I/l`. 
- Add a dark mode or more advanced theming. 
- Add a strength indicator for the generated password. 
- Localize UI strings into multiple languages. 

## Requirements

- Windows 10 or Windows 11 (for running the Windows target). 
- .NET SDK compatible with the MAUI version used in the project. 
- Visual Studio 2022 with **.NET Multi-platform App UI development** workload.

## Contributing

If you want to contribute or suggest improvements: 

1. Fork this repository. [web:21][web:39]  
2. Create a feature branch. [web:21][web:31]  
3. Commit and push your changes. [web:21][web:36]  
4. Open a Pull Request describing what you changed. 

## License

This project is open source under the [MIT License](LICENSE).

