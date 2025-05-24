Hello!

Thank you for taking a moment to look at this scripture memorization project. This simple console application was created as part of the Week 3 assignment for the CSE 210 course at BYU-Idaho.

The idea is to help people practice and memorize scriptures by gradually hiding words from a passage, encouraging them to recall the missing pieces from memory. It’s a useful and motivating tool for anyone trying to internalize sacred texts.

How It Works
------------
When you run the program, a scripture will appear on your screen. Each time you press the Enter key, a few more words will disappear and be replaced with underscores. You can keep pressing Enter to challenge yourself as more and more of the passage is hidden.

If at any point you want to stop, just type "quit" and press Enter.

What Makes This Version Special?
--------------------------------
- It includes multiple scriptures, chosen randomly each time the app starts.
- Words are hidden intelligently — only words that are still visible get hidden.
- The design is clean and easy to understand, so you can focus on memorizing instead of figuring out how the program works.

Behind the Scenes
-----------------
The program uses four main C# files:
- Program.cs: The main controller of the app.
- Scripture.cs: Manages the scripture text and word hiding.
- Reference.cs: Handles scripture references like "John 3:16" or "Proverbs 3:5-6".
- Word.cs: Represents each individual word, hidden or not.

Everything follows the principles of encapsulation, with each class doing one job well.

How to Run It
-------------
1. Open your terminal or command prompt.
2. Navigate to the folder where these files are located.
3. Run the following commands:

dotnet build
dotnet run

Thank You
---------
I hope this little tool can be helpful and even uplifting. If you’re using it for your own spiritual practice or just to learn how encapsulated programming works — either way, I’m grateful you’re here.

- Nuno
