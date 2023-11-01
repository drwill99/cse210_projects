using System;

public class JournalPrompts
{
   
    private string[] prompts = 
    
    {    

    "What are three things you are grateful for today, and why?",
    "Describe a time when you overcame a significant challenge in your life. What did you learn from that experience?",
    "Write about a goal or dream you have for the future.",
    "Explore a childhood memory that still resonates with you today.",
    "Write a letter to your future self, reflecting on where you hope to be in five years.",
    "What is a book or movie that has had a profound impact on your life? Describe why it affected you.",
    "Discuss a person who has been a positive influence in your life and the reasons behind it.",
    "Explore your favorite hobbies and why they bring you joy.",
    "Write about a time when you felt truly inspired or motivated.",
    "Describe a place that holds special meaning for you, and why it's significant.",
    "Share a recent accomplishment, no matter how small, and how it made you feel.",
    "Write a list of your short-term and long-term goals, and outline a plan to achieve them.",
    "Reflect on a mistake or failure you've experienced and the lessons you've learned from it.",
    "What are your core values, and how do they shape your decisions and actions?",
    "Explore your ideal day from start to finish, including your daily routine and activities.",
    "Write a letter to your past self, offering advice and encouragement.",
    "Discuss a person or situation that has been a source of stress in your life and how you've coped with it.",
    "Describe a time when you felt completely at peace and content. What were the circumstances?",
    "Write about a skill or talent you'd like to develop and why it's important to you.",
    "What are your favorite quotes or mantras, and how do they resonate with your life?",
    "Explore the role of forgiveness in your life and any experiences related to it.",
    "Write about a moment when you felt deeply connected with someone or something in nature.",
    "Reflect on your proudest moments and achievements in life so far.",
    "Write about your morning routine and how it sets the tone for your day.",
    "Share your thoughts on a recent news event or social issue that has captured your attention.",
    "Describe a place you'd like to visit or explore in the future and what draws you to it.",
    "Explore your relationships with family members and how they've influenced your life.",
    "Write about your self-care routines and the importance of taking care of yourself.",
    "Reflect on a decision you're currently facing and the factors that are influencing your choice.",
    "What are your favorite ways to relax and unwind after a long day?",
    "Write about a fear or insecurity you've been working to overcome and your progress.",
    "Describe the qualities you admire in others and how they inspire you.",
    "Discuss a moment when you felt a strong sense of belonging and connection with a group or community.",
    "Share your favorite recipes, along with the memories or stories associated with them.",
    "Explore your creative outlets, such as art, writing, or music, and how they allow you to express yourself.",
    "Write about a time when you experienced a major change in your life and how you adapted to it.",
    "Reflect on the concept of happiness and what it means to you.",
    "Share your favorite travel experiences and the impact they've had on your perspective.",
    "Write a letter to someone you need to forgive or seek forgiveness from.",
    "Explore your daily habits and routines, and consider how they contribute to your overall well-being.",
    "Describe a recent act of kindness you witnessed or participated in.",
    "Reflect on your personal strengths and how you can leverage them in your life.",
    "Write about a mentor or role model who has influenced your personal or professional growth.",
    "Share your thoughts on a current challenge or obstacle you're facing and possible solutions.",
    "Reflect on your favorite childhood games and the memories associated with them.",
    "Describe a moment when you felt a strong sense of wonder or awe.",
    "Explore your dreams and aspirations for the future, both big and small."

    };
    public string getPrompt()
    {
        Random randomGenerator = new Random();
        int promptNumber = randomGenerator.Next(0,prompts.Length);
        return prompts[promptNumber];
    
    }
        
}   