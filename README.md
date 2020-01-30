# BugRepro.WinFormsComboBox
Repro case for a bug in WinForms (net48 &amp; netcoreapp3.1)

1. Clone the repro
2. ``dotnet build``
    * The output is 3 versions: net472, net48 & netcoreapp3.1
3. Run the net472 version
4. Click ``Update``
    * Note that all the rows in the table have the same controls.
    * This is the correct behaviour
6. Repeat with net48 and netcoreapp3.1 builds
    * Note that the first rows in the table has two of the controls swapped.
    
__N.B.__ Using quirks to disable the new Accessibility features in .Net 4.8 will restore the correct behaviour.  
