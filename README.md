# IDL 4 Sparx Enterprise Architect Extension
Sparx Enterprise Architect Extension to generate IDL 4 (RTI Connext DDS) files from the Enterprise Architect UML model.

The IDL4 extension creates a menu entry in Sparx Enterprise Architect that can be used to generate IDL from the current UML Model or parts of that model.

To install the IDL4 extension you must have Sparx Systems Enterprise Architect already installed in your system. The IDL4 extension has been tested with Sparx Enterprise Architect version 10, 12 and 13.5. See the notes associated with release for information on the version(s) of Enterprise Architect it has been tested against.

The IDL generated uses the syntax of the latest version of the [OMG IDL specification: IDL 4.1](http://www.omg.org/spec/IDL/). For backwards compatibility there is an option to use the legacy [OMG DDS-XTYPES version 1.1](http://www.omg.org/spec/DDS-XTypes/) syntax as well. 

## Support and Feedback
Please report any issues you find at https://github.com/rticommunity/idl4-enterprise-architect/issues and use the [RTI Community forums](http://community.rti.com) to discuss the plugin and provide feedback. 

## Installing the IDL 4 Sparx Enterprise Architect Extension
To install the IDL4 extension. You may download an installer with the latest release from here:
https://github.com/rticommunity/idl4-enterprise-architect/releases

Then, double click on its icon and follow the on-screen instructions to complete the installation.

The installation includes the documentation directory **doc** with the file  [Mapping_UML_to_IDL.pdf](https://github.com/rticommunity/idl4-enterprise-architect/blob/master/doc/Mapping_UML_to_IDL.pdf), this contains a description of the UML to IDL mapping rules. There is also an example UML model **ExampleDataClasses.eap** in the example directory that illustrates the functionality of the extension.

## Contributing to the Repository

To contribute enhancements or additional functionality to the repository, submit pull requests using GitHub's usual mechanisms.

IDL4 Sparx Enterprise Architect Extension source code is distributed under the [Apache License, Version 2.0](LICENSE).
