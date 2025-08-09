# 📱 Calculator Program

## 🔎 Project OverView

A modern, feature-rich console calculator application built with C# and .NET
9.0. This application provides a clean, interactive interface for performing
basic arithmetic operations while maintaining detailed operation history and
comprehensive logging.

> Note: This game should played on a unix based terminal for the best user
> experience 🙋‍♂️

## 📚 Table of Contents

- [✨ Features](#-features)
- [🏗️ Architecture](#️-architecture)
- [🛠️ Technology Stack](#️-technology-stack)
- [📦 NuGet Dependencies](#-nuget-dependencies)
- [📋 Prerequisites](#-prerequisites)
- [🚀 Getting Started](#-getting-started)
- [📖 Project Details](#-project-details)
- [📊 Logging](#-logging)
- [🎨 User Interface](#-user-interface)
- [🔧 Development](#-development)
- [🚀 Future Enhancements](#-future-enhancements)
- [🎯 Skills Acquired](#-skills-acquired)
- [🤝 Contributing](#-contributing)
- [📞 Support](#-support)

## ✨ Features

- 🔢 **Basic Arithmetic Operations**: Addition, Subtraction, Multiplication,
  Division
- 📊 **Operation History**: View and manage calculation history
- 📝 **JSON Logging**: Comprehensive logging of all operations to
  `calculatorlog.json`
- 🎨 **Colorful UI**: Interactive console interface with ASCII art and colored
  output
- ⚡ **Real-time Validation**: Input validation with user-friendly error
  messages
- 📈 **Usage Tracking**: Automatic counting of total operations performed
- 🧩 **Modular Architecture**: Clean separation of concerns across multiple
  projects

## 🏗️ Architecture

The solution follows a modular design pattern with four distinct projects:

```
CalculatorProgram.sln
├── 🚀 CalculatorProgram/          # Main console application
├── 🧮 CalculatorLibrary/          # Core calculation logic & JSON logging
├── 🎨 CalculatorResults/          # Result display formatting
└── 🔧 Utilities/                  # Input handling & validation helpers
```

## 🛠️ Technology Stack

- **Framework**: .NET 9.0
- **Language**: C# with nullable reference types
- **Target Platform**: Cross-platform console application

## 📦 NuGet Dependencies

### Newtonsoft.Json v13.0.3

- **Purpose**: JSON serialization and deserialization
- **Usage**: Logs all calculator operations to a structured JSON file
- **Benefits**:
  - High-performance JSON processing
  - Comprehensive serialization options
  - Wide industry adoption and reliability
  - Flexible data formatting for audit trails

## 📋 Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- Any IDE that supports .NET (Visual Studio, VS Code, Rider, etc.)

## 🚀 Getting Started

### Installation

1. **Clone the repository**

   ```bash
   git clone <repository-url>
   cd CalculatorProgram
   ```

2. **Restore dependencies**

   ```bash
   dotnet restore
   ```

3. **Build the solution**

   ```bash
   dotnet build
   ```

4. **Run the application**

   ```bash
   cd CalculatorProgram
   dotnet run
   ```

### Usage

Upon launching the application, you'll see an interactive menu with the
following options:

```
╔═══════════════════════════════════════╗
║          CALCULATOR APP v1.0         ║
║     Welcome to the Calculator App    ║
╚═══════════════════════════════════════╝

AVAILABLE OPERATIONS:
────────────────────
   [A] + Addition
   [S] - Subtraction
   [M] * Multiplication
   [D] / Division
   [E] X Exit Program
   [H] View History
   [X] Clear History
```

## 📖 Project Details

### Core Components

#### 🧮 CalculatorLibrary

- **Purpose**: Core calculation engine with comprehensive logging
- **Key Features**:
  - Performs all arithmetic operations
  - Logs operations to JSON file with structured format
  - Tracks usage statistics
  - Handles mathematical errors (e.g., division by zero)

#### 🎨 CalculatorResults

- **Purpose**: Professional result formatting and display
- **Key Features**:
  - Formatted result display with ASCII borders
  - Smart number formatting (integers vs decimals)
  - Color-coded output for better readability

#### 🔧 Utilities

- **Purpose**: User input handling and validation
- **Key Features**:
  - Robust number input validation
  - Operation selection with error handling
  - Consistent user experience across all inputs

#### 🚀 CalculatorProgram

- **Purpose**: Main application orchestrator
- **Key Features**:
  - Application lifecycle management
  - History management and display
  - User interaction flow control
  - Clean console interface with helper methods

### 📁 File Structure

```
CalculatorProgram/
├── CalculatorProgram/
│   ├── Program.cs              # Main application entry point
│   ├── Helpers.cs              # UI helpers and console utilities
│   └── CalculatorProgram.csproj
├── CalculatorLibrary/
│   ├── CalculatorLibrary.cs    # Core calculation logic
│   └── CalculatorLibrary.csproj
├── CalculatorResults/
│   ├── PrintResult.cs          # Result formatting
│   └── CalculatorResults.csproj
├── Utilities/
│   ├── Utility.cs              # Input validation utilities
│   └── Utilities.csproj
└── CalculatorProgram.sln       # Solution file
```

## 📊 Logging

The application automatically creates a `calculatorlog.json` file in the
executable directory, containing:

```json
{
	"Operations": [
		{
			"Operand1": 10.0,
			"Operand2": 5.0,
			"Operation": "Add",
			"Result": 15.0
		}
	]
}
```

## 🎨 User Interface

The application features a rich console interface with:

- **Color-coded output** for different types of information
- **ASCII art borders** for visual appeal
- **Formatted result displays** with operation details
- **Interactive menus** with clear navigation options
- **Error messages** with helpful guidance

## 🔧 Development

### Building from Source

```bash
# Build in Debug mode
dotnet build --configuration Debug

# Build in Release mode
dotnet build --configuration Release
```

### Code Style

The project follows standard C# conventions:

- PascalCase for public members
- camelCase for private fields
- Meaningful variable and method names
- Comprehensive error handling
- Nullable reference types enabled

## 🚀 Future Enhancements

The following features are planned for future releases:

### 🧮 Advanced Mathematical Operations

- **Exponential Functions**: Power calculations (x^y)
- **Square Root Operations**: √x calculations
- **Trigonometric Functions**: sin, cos, tan operations
- **Logarithmic Functions**: Natural and base-10 logarithms
- **Statistical Functions**: Mean, median, standard deviation

### 📊 Enhanced History Management

- **History-based Calculations**: Use previous results in new calculations
- **Individual Operation Deletion**: Remove specific calculations from history
- **History Export**: Export calculation history to CSV/PDF formats
- **Search and Filter**: Find specific calculations in history
- **History Analytics**: Usage patterns and calculation statistics

### 🤖 AI Integration

- **Voice Input Recognition**: Accept mathematical expressions via voice
  commands
- **Natural Language Processing**: Process queries like "What's fifteen plus
  twenty-seven?"
- **Smart Suggestions**: AI-powered operation recommendations
- **Voice Output**: Audio feedback for results and confirmations

### 🎨 User Experience Improvements

- **Themes**: Dark/Light mode console themes
- **Customizable Interface**: User-configurable color schemes
- **Keyboard Shortcuts**: Quick access to common operations
- **Multi-language Support**: Localization for different languages

## 🎯 Skills Acquired

Working on this project demonstrates proficiency in:

### 🔧 Technical Skills

- **.NET Core Development**: Modern C# application development
- **Object-Oriented Programming**: Clean class design and inheritance
- **Modular Architecture**: Separation of concerns and project organization
- **JSON Serialization**: Data persistence and structured logging
- **Error Handling**: Robust exception management and user feedback
- **Input Validation**: Secure and user-friendly data processing

### 💻 Software Engineering

- **Console Application Development**: Interactive CLI applications
- **Project Structure**: Multi-project solution organization
- **Dependency Management**: NuGet package integration
- **Code Documentation**: Comprehensive inline and external documentation
- **Version Control**: Git workflow and repository management

### 🎨 User Experience

- **Interface Design**: Intuitive console UI with visual feedback
- **User Flow Design**: Logical application navigation
- **Accessibility**: Clear error messages and user guidance
- **Visual Design**: ASCII art and color-coded output

## 🤝 Contributing

This project welcomes contributions from developers of all skill levels! Since
this project is not licensed, all contributions are accepted and appreciated.

### 🌟 How to Contribute

1. **Fork the Repository**

   ```bash
   git clone https://github.com/your-username/CalculatorProgram.git
   cd CalculatorProgram
   ```

2. **Create a Feature Branch**

   ```bash
   git checkout -b feature/your-feature-name
   ```

3. **Make Your Changes**

   - Follow the existing code style and conventions
   - Add appropriate comments and documentation
   - Ensure your code builds without errors

4. **Test Your Changes**

   ```bash
   dotnet build
   dotnet run
   ```

5. **Commit Your Changes**

   ```bash
   git add .
   git commit -m "Add: Your descriptive commit message"
   ```

6. **Push to Your Fork**

   ```bash
   git push origin feature/your-feature-name
   ```

7. **Create a Pull Request**
   - Provide a clear description of your changes
   - Reference any related issues
   - Include screenshots if applicable

### 🎯 Contribution Areas

- **Bug Fixes**: Report and fix issues
- **Feature Development**: Implement new calculator functions
- **UI Improvements**: Enhance the console interface
- **Documentation**: Improve code comments and README
- **Performance**: Optimize calculation algorithms
- **Testing**: Add unit tests and integration tests

### 📋 Contribution Guidelines

- Keep commits focused and atomic
- Write clear, descriptive commit messages
- Follow existing code formatting and naming conventions
- Add comments for complex logic
- Update documentation for new features
- Be respectful and collaborative in discussions

## 📞 Support

For questions or issues, please create an issue in the repository or contact the
development team.

---

<div align="center">
  <strong>Built with ❤️ using C# and .NET 9.0</strong>
</div>
