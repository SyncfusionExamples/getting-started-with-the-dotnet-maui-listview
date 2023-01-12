using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject
{
    public class BookViewModel
    {
        public ObservableCollection<string> Books { get; set; }

        public ObservableCollection<BookInfo> BookDetails { get; set; }

        public BookViewModel() {

            BookDetails = new ObservableCollection<BookInfo>()
            {
                new BookInfo { BookName = "Object-Oriented Programming in C#", BookDescription = "Object-oriented programming uses objects to design programs" },
                new BookInfo { BookName = "C# Code Contracts", BookDescription = "Code Contracts provide a way to convey code assumptions" },
                new BookInfo { BookName = "Machine Learning Using C#", BookDescription = "Learn several different approaches to applying machine learning" },
                new BookInfo { BookName = "Neural Networks Using C#", BookDescription = "Neural networks are an exciting field of software development" },
                new BookInfo { BookName = "Visual Studio Code", BookDescription = "It is a powerful tool for editing code and serves for end-to-end programming" },
                new BookInfo { BookName = "Android Programming", BookDescription = "It provides a useful overview of the Android application life cycle" },
                new BookInfo { BookName = "iOS Succinctly", BookDescription = "It is for developers looking to step into frightening world of iPhone" },
                new BookInfo { BookName = "Visual Studio 2015", BookDescription = "The new version of the widely-used integrated development environment" },
            };

            Books = new ObservableCollection<string>
            {
                ".NET MAUI Guidelines",
                "Introduction to .NET MAUI",
                "Learn .NET MAUI",
                ".NET MAUI First look",
                "What is .NET MAUI",
                "Learn .NET Community Toolkit",
                "A Journey to .NET MAUI",
                ".NET MAUI community stand up",
                ".NET MAUI samples demo",
                ".NET MAUI community samples",
                "Sample browser",
                "com.syncfusion.samplebrowser.maui.Signed",
                "com.android.chrome",
                "com.android.vending",
                "com.android.mediacenter",
                "Syncfusion Gallery",
                "Syncfusion Orientation Program"
            };
        }
    }
}
