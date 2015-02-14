# SolutionInspector
Visual Studio solution structure and settings validator.
The tool checks for solution and project files to be consistent as well as project settings to match the designated values.

# Running the tool
SolutionInspector.exe YourMasterPiece.sln

## Solution-wide validation settings
The tool will use the default validation settings unless you place *SolutionInspector.xml* file along with the solution file.
You basically do the same for StyleCop or ReSharper settings.

## Project-specific settings
You may place *SolutionInspector.xml* files along with your project files.
The settings in such files will override the Solution-wide settings.

# SolutionInspector.xml file example
``` xml
<?xml version="1.0" encoding="utf-8"?>
<Settings xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">

	<SolutionSettings>
		<MinSolutionFormatVersion>12.00</MinSolutionFormatVersion>
		<MaxSolutionFormatVersion>12.00</MaxSolutionFormatVersion>
		<DetectMissingFiles>true</DetectMissingFiles>
		<ProjectNamePrefix>MyCompany.MyProduct.</ProjectNamePrefix>
		<ProjectNameIsFileName>true</ProjectNameIsFileName>
		<IgnoredProjects>
			AVerySpecialProject1;
			AVerySpecialProject2;
		</IgnoredProjects>
	</SolutionSettings>

	<ProjectSettings>
		<DetectMissingFiles>true</DetectMissingFiles>
		<AllowBuildEvents>true</AllowBuildEvents>
		<AssemblyNameIsProjectName>true</AssemblyNameIsProjectName>
		<RootNamespaceIsAssemblyName>true</RootNamespaceIsAssemblyName>
		<RequiredImports>StyleCop.MSBuild.Targets</RequiredImports>
		<Properties>
			<TreatWarningsAsErrors>true</TreatWarningsAsErrors>
			<StyleCopTreatErrorsAsWarnings>false</StyleCopTreatErrorsAsWarnings>
		</Properties>
	</ProjectSettings>

</Settings>
```
