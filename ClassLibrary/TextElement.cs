using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class TextElement
    {
        public abstract int CountLetters();

        public abstract override string ToString();

        public virtual string DisplayInfo()
        {
            return ($"Элемент текста: {ToString()}, Количество букв: {CountLetters()}");
        }
    }
}
