# ms-unit-test-output-comparerer
Winforms app to compare Expected/Actual ms unit test json output side by side.

The MS unit tests build into Visual Studio output the actual and expected data on one line. This is especially useless when you're comparing two huge JSON strings. This little winforms app lets you paste the entire output into it and then puts Expected on the left and Actual on the right by parsing and formatting the json.
