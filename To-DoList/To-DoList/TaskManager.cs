using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace To_DoList
{
    public class TaskManager
    {
        private readonly List<TaskItem> tasks = new();
        private const string SavePath = "tasks.json";

        public IReadOnlyList<TaskItem> Tasks => tasks;

        public void AddTasks(string title, string description)
        {
            tasks.Add(new TaskItem(title, description));
            SaveToFile();
        }

        public void CompleteTask(int index)
        {
            if (index < 0 || index >= tasks.Count)
                return;

            tasks[index].IsComplete = true;
            SaveToFile();
        }

        public void UncompleteTask(int index)
        {
            if (index < 0 || index >=  Tasks.Count)
                return;

            tasks[index].IsComplete = false;
            SaveToFile();
        }

        public void DeleteTask(int index)
        {
            if (index < 0 || index >= tasks.Count)
                return;

            tasks.RemoveAt(index);
            SaveToFile();
        }

        public IReadOnlyList<TaskItem> ActiveTasks =>
            tasks.Where(t => !t.IsComplete).ToList();

        public IReadOnlyList<TaskItem> CompletedTasks =>
            tasks.Where(t => t.IsComplete).ToList();

        public void LoadFromFile()
        {
            if (!File.Exists(SavePath))
                return;

            string json = File.ReadAllText(SavePath);
            var loaded = JsonSerializer.Deserialize<List<TaskItem>>(json);

            if (loaded != null)
            {
                tasks.Clear();
                tasks.AddRange(loaded);
            }
        }

        public void SaveToFile()
        {
            File.WriteAllText(
                SavePath,
                JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true })
             );
        }
    }
}
