# Network Command Tool

## Overview
The Network Command Tool is a C#-based application designed to simplify the execution of advanced network commands such as ARP, Ping, Netsh, and NetBIOS. It provides a user-friendly graphical interface, making it accessible for users who may not be comfortable using the command line.

## Features
- **ARP Module**: 
  - View the ARP table and display all network entries.
  - Send ARP requests to specific IP addresses.

- **Ping Module**: 
  - Ping a domain or IP address with configurable request counts.
  - Display ping results in both textual and graphical formats.

- **Netsh Module**: 
  - Display system network configurations.
  - Configure static IP addresses, subnet masks, and gateways for advanced users.

- **NetBIOS Module**: 
  - Scan for NetBIOS names on the local network.
  - Display the NetBIOS names of the system.

## User Interface
The application features a clean and intuitive interface built using Windows Forms or WPF. It includes:
- Tabs for grouping functionalities:
  - Tab 1: ARP operations.
  - Tab 2: Ping operations (with options for graphical view).
  - Tab 3: Network configuration (IP, Subnet, Gateway).
  - Tab 4: NetBIOS scans.
- A status bar or log window for displaying execution statuses.

## Installation
1. Clone the repository:
   ```
   git clone https://github.com/amir13872/NetworkCommandTool.git
   ```
2. Navigate to the project directory:
   ```
   cd NetworkCommandTool
   ```
3. Open the project in your preferred C# development environment.
4. Restore the project dependencies:
   ```
   dotnet restore
   ```
5. Build the project:
   ```
   dotnet build
   ```

## Usage
- Launch the application to access the main interface.
- Use the tabs to navigate between different network operations.
- Follow the on-screen instructions to execute commands and view results.

## Security
The application includes input validation and sanitization to prevent command injection and restrict operations to avoid unintended system changes.

## Future Enhancements
- Graphical charts for ping response times or network scans.
- Exporting results to PDF.
- Scheduling automatic command execution.
- Multi-language support.

## License
This project is licensed under the MIT License. See the LICENSE file for more details.
