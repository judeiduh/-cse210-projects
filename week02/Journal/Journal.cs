class Journal:
    def __init__(self):
        self.entries = []
    
    def add_entry(self, entry):
        """Adds a journal entry."""
        self.entries.append(entry)
    
    def get_entries(self):
        """Returns all journal entries."""
        return self.entries
    
    def display_entries(self):
        """Displays all entries along with the date and prompt."""
        for entry in self.entries:
            print(f"Date: {entry.date}\nPrompt: {entry.prompt}\nEntry: {entry.text}\n")
    
    def save(self, filename):
        """Saves journal entries to a file."""
        with open(filename, 'w') as file:
            for entry in self.entries:
                file.write(f"{entry.date},{entry.prompt},{entry.text}\n")
    
    def load(self, filename):
        """Loads journal entries from a file."""
        try:
            with open(filename, 'r') as file:
                for line in file:
                    date, prompt, text = line.strip().split(',', 2)
                    self.add_entry(Entry(date, prompt, text))
        except FileNotFoundError:
            print("File not found. Starting with an empty journal.")
