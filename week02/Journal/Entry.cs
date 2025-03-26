from datetime import datetime

class Entry:
    def __init__(self, date, prompt, text):
        self.date = date
        self.prompt = prompt
        self.text = text
    
    @classmethod
    def create_entry(cls, prompt, text):
        """Creates a journal entry with the current date."""
        date = datetime.now().strftime("%Y-%m-%d %H:%M:%S")
        return cls(date, prompt, text)
