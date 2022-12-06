namespace Prototype
{
    public class ColorObject : ColorPrototype
    {
        public ColorObject(UnityEngine.Color color)
        {
            this.color = color;
        }

        public override ColorPrototype Clone()
        {
            UnityEngine.Debug.Log(this.color.ToString());
            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}