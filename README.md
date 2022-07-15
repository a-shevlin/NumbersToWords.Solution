# Numbers To Words

#### By _**Alex Shevlin, Zac Waggoner, Tyler Emmerson**_  

#### _Translates numbers and returns them as written words._  

---

## Table of Contents

**[Technologies Used](#technologies-used)  
[Description](#description)  
[Setup and Installation](#setupinstallation-requirements)  
[Known Bugs](#known-bugs)  
[License](#license)  
[Tests](#tests)**

---
## Technologies Used

* _C#_
* _.NET_

---
## Description

_Takes an integer and translates into written words. Ex: 384 to three hundred and eighty four._

---
## Setup/Installation Requirements

* Install *`Microsoft .NET SDK`*
* Place files in a folder named `NumbersToWords.Solution`
    <pre>NumbersToWords.Solution
    ├── NumbersToWords
    └── NumbersToWords.Tests</pre>
<details>
<summary><strong>To Run</strong></summary>
Navigate to  
   <pre>NumbersToWords.Solution
   ├── <strong>NumbersToWords</strong>
   └── NumbersToWords.Tests</pre>

Run ```$ dotnet run``` in the console
</details>

<details>
<summary><strong>For Testing</strong></summary>
Navigate to  
    <pre>NumbersToWords.Solution
    ├── NumbersToWords
    └── <strong>NumbersToWords.Tests</strong></pre>

Run ```$ dotnet test``` in the console

</details>
<br>

This program was built using *[Microsoft .NET SDK 5.0.401](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* _Any known issues_
* _should go here_

## License

[MIT](/LICENSE)

Copyright (c) 2022 Alex Shevlin, Zac Waggoner, Tyler Emmerson

### **Tests**

#### *WordTests*

<table>
  <tr>
    <th>Describe</th>
    <th>Code</th>
    <th>Expected Output</th>
  </tr>
  <tr>
    <td>return input word to string</td>
    <td>
    string test = "test";
    <br>
    Word newWord = new Word(test);
    </td>
    <td>newWord.IsWord() is true</td>
  </tr>
    <tr>
    <td>check for word in string</td>
    <td>
    string test = "";
    <br>
    Word newWord = new Word(test);
    </td>
    <td>newWord.IsWord() is false</td>
  </tr>
    <tr>
    <td>return input word to an array</td>
    <td>
    string test = "test"
    <br>
    Word newWord = new Word(test);
    <br>
    newWord.SetInputArray();
    </td>
    <td>newWord.InputArray === {'t', 'e', 's', 't'}</td>
  </tr>
    <tr>
    <td>return score based on letter</td>
    <td>
    string test = "test";
    <br>
    Word newWord = new Word(test);
    <br>
    newWord.SetInputArray();
    <br>
    newWord.AddScore();
    </td>
    <td>newWord.WordScore === 4</td>
  </tr>
</table>

#### *NumberTests*

<table>
  <tr>
    <th>Describe</th>
    <th>Code</th>
    <th>Expected Output</th>
  </tr>
  <tr>
    <td>returns input string to int array</td>
    <td>
      string test = "1234";
    <br>
      Number newNumber = new Number(test);
    <br>
      newNumber.SetInputArray();
    </td>
    <td>newNumber.InputArray === 1, 2, 3, 4};</td>
  </tr>
  <tr>
  </tr>
