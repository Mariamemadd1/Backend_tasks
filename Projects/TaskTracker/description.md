✅ Task Tracker – Console App in C#
This is a simple C# console application that allows users to track their daily tasks. The program lets users add, remove, mark, and view tasks in a clean command-line interface.

🛠 Features
✅ Add a new task

❌ Remove task by name or by ID

👀 View all current tasks

✔️ Mark tasks as completed

📋 View completed tasks

🚪 Exit the app

📂 How It Works
When the app runs, it shows a menu like this:

pgsql
Copy
Edit
1. Add Task  
2. Remove Task (by name)  
3. Remove Task (by ID)  
4. View Tasks  
5. Mark Task as Completed  
6. View Completed Tasks  
7. Exit
Each task is stored in a list, and completed tasks are moved to a separate list.

📌 Code Highlights
Uses two List<string> collections:

tasks: for current tasks

MarkedTasks: for completed tasks

Uses indexing to handle removal and marking by ID

Easy-to-navigate while loop for command handling
