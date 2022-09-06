using System;
using System.Collections.Generic;
using System.Text;

namespace testOOP
{
    class Animal
    {
        //data members
        protected bool mammals { get; set; }
        private bool carnivorous { get; set; }
        private static int moodHappy = 1;  
        private int moodScare = -1; 
        private int mood { get; set; }


        public int MoodHappy
        {
            get { return moodHappy; }
            //בדיקה על הערך שהוכנס - חייב להיות גדול מ 0
            //set
            //{
            //    if (value < 0)
            //        return;

            //    moodHappy = value;
            //}
        }

        public int MoodScare
        {
            get { return moodScare; }
            //בדיקה על הערך שהוכנס - חייב להיות קטן מ 0
            //set
            //{
            //    if (value > 0)
            //        return;

            //    moodScare = value;
            //}
        }

        public Animal()
        {

        }

        public Animal(bool mammals, bool carnivorous, int mood)
        {
            this.mammals = mammals;
            this.carnivorous = carnivorous;
            this.mood = mood;
        }

        //אמירת שלום שמרגיש רגוע
        public virtual void sayHello()
        {
            Console.WriteLine("HELLO");
        }

        //אמירת שלום במצב שמח / מפוחד
        public virtual void sayHello(int mood)
        {
            Console.WriteLine("HELLO WITH INT");
        }

        //האם יונק?
        public virtual bool isMammals()
        {
            return true;
        }

        public virtual void setMammals(bool mammals)
        {
            Console.WriteLine("setMammals");
        }

        //האם טורף?
        public virtual bool isCarnivorous()
        {
            return false;
        }

        public virtual void setCarnivorous(bool carnivorous)
        {
            Console.WriteLine("setCarnivorous");
        }

    }
}
