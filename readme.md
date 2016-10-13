#CurrencyConverter
##Synopsis
This is a currency converter library. It supports the following features:
[x] Converting currency to word equivalents.

##Code Example
###Assignment
Write a class that implements method(s) to convert a monetary amount into its word equivalent. The input monetary amount will be greater than -R1000.00 and less than R1000.00 and may consist of no more than 2 decimal places (additional decimal places should be ignored). The conversion must be robust and report errors when they occur.

The following are possible results which can be expected::

```
| Input | Output |
|--------|--------|
|    R 0    |    zero rand    |
|    R0.00    |    zero rand and zero cents    |
|    R12    |     twelve rand   |
|    -R22    |     minus twenty two rand   |
|    R112.01    |    one hundred and twelve rand and one cent    |
|    200    |    Two hundred rand    |
|    R a    |    Error (invalid rand value)    |
|    100.0x    |    Error (invalid cents values)    |
|        |    Error (empty string)    |
|    1000    |    Error (rand value out of range)    |
```

###Deductions
From the instructions given, the following assumptions can be deducted from it:
- The currency symbol will always be ‘R’ but may not be present.
- The minus symbol will always appear in front of the rand value but may not be present.
- The cents component may not appear.
- Ignore decimal values below 0.01.


###Code Snippet
Todo:
```javascript
Todo
```

##Installation
To run this app, you'll need .NET 4.5 or higher installed on your machine, and to open up the project file you'll need Visual Studio. Other than that, no installation required. Microsoft .NET Framework 4.5 can be installed by downloading it from the microsoft website.

##Contributors
Feel free to pop me a message or flag an issue if you come across it - I'll see what I can do about it.

##License

Copyright © `2016` `Simone van Buuren`

Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the “Software”), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.