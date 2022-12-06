using System.Collections.Generic;

namespace Prototype
{
    public class ColorObjectsManager
    {
        private Dictionary<string, ColorPrototype> _colorObjects = new();

        public ColorPrototype this[string key]
        {
            get { return _colorObjects[key]; }
            set { _colorObjects.Add(key, value);}
        }
    }
}