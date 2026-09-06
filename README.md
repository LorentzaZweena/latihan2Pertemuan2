# Latihan 2 - Visual Basic .NET

This project is the second practical exercise using Visual Basic .NET and Windows Forms.

## Description

This application demonstrates a simple image gallery and date processing using Windows Forms controls. Users can select an image from a list, display the selected image, and select a date for an activity.

## Features

- Display images using `PictureBox`
- Select images using `ListBox`
- Show loading progress using `ProgressBar`
- Select a date using `DateTimePicker`
- Display the selected date using a `MessageBox`
- Display a message when no image is selected
- Handle missing image files

## Tools & Technologies

- Visual Studio 2022
- Visual Basic .NET
- Windows Forms
- .NET 8.0

## Project Structure

```text
latihan2Pertemuan2/
│
├── Images/
│   ├── 1.png
│   └── 2.png
│
├── My Project/
├── ApplicationEvents.vb
├── Form1.vb
├── Form1.Designer.vb
├── Form1.resx
└── latihan2Pertemuan2.vbproj
````

## How to Run

1. Clone this repository.
2. Open the project in Visual Studio 2022.
3. Open the solution/project file.
4. Make sure the `Images` folder contains `1.png` and `2.png`.
5. Build the project.
6. Run the application by clicking **Start** or pressing `F5`.

## How the Application Works

1. The application loads `1.png` and `2.png` into the `ListBox`.
2. Select an image from the list.
3. Click the **Tampilkan** button.
4. The `ProgressBar` shows the loading process.
5. The selected image is displayed in the `PictureBox`.
6. The selected date is displayed using a message box.

## Author

**Latihan 2 - Pertemuan 2**

Visual Basic .NET Practical Exercise
