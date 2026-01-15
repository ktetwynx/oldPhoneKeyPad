# 📱 Old Phone Keypad Converter (C#)

This project converts old mobile phone keypad input into readable text, similar to classic Nokia phones.

## How the Logic Works

The program processes the input character by character using two StringBuilder objects:

1️⃣ buffer

Temporarily stores repeated digits

Example: "777"

2️⃣ output

Stores the final converted text

Example: "TUR"

## Code Structure

Main() → starts the program

ConvertKeypadInput() → processes input string

Commit() → converts digit groups into letters

## How to run

Type `dotnet run` at Terminal


---

- `2` → A
- `22` → B
- `222` → C
- `777` → R

Special characters:
- `space` → separates letters  
- `*` → deletes the last typed letter  
- `#` → ends input  

---

## Example

OldPhonePad(“33#”) => output: E
OldPhonePad(“227*#”) => output: B
OldPhonePad(“4433555 555666#”) => output: HELLO
OldPhonePad(“8 88777444666*664#”) => output: TURING

List of AI-Prompt during development

* how to use key hash to store the value in c#.
* how to modify string in c#

https://chatgpt.com/share/6968916d-9eec-8000-858a-54a515cc89fe






