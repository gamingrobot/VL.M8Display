namespace VL.M8Display;

public enum ButtonEnum
{
    Edit,
    Option,
    Play,
    Shift,
    Up,
    Down,
    Right,
    Left,
}

[Flags]
internal enum ButtonFlags : byte
{
    // None = 0,
    Edit = 1,
    Option = 2,
    Right = 4,
    Play = 8,
    Shift = 16,
    Down = 32,
    Up = 64,
    Left = 128,
}

public static class ButtonHelpers
{
    public static IEnumerable<ButtonEnum> FromByte(byte b)
    {
        if (b == 0)
        {
            return new List<ButtonEnum>();
        }

        var input = (ButtonFlags)b;
        var result = new List<ButtonEnum>();
        if (input.HasFlag(ButtonFlags.Edit))
        {
            result.Add(ButtonEnum.Edit);
        }
        if (input.HasFlag(ButtonFlags.Option))
        {
            result.Add(ButtonEnum.Option);
        }
        if (input.HasFlag(ButtonFlags.Play))
        {
            result.Add(ButtonEnum.Play);
        }
        if (input.HasFlag(ButtonFlags.Shift))
        {
            result.Add(ButtonEnum.Shift);
        }
        if (input.HasFlag(ButtonFlags.Up))
        {
            result.Add(ButtonEnum.Up);
        }
        if (input.HasFlag(ButtonFlags.Down))
        {
            result.Add(ButtonEnum.Down);
        }
        if (input.HasFlag(ButtonFlags.Right))
        {
            result.Add(ButtonEnum.Right);
        }
        if (input.HasFlag(ButtonFlags.Left))
        {
            result.Add(ButtonEnum.Left);
        }

        return result;
    }

}