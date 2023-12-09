/*
 *  This file is part of CounterStrikeSharp.
 *  CounterStrikeSharp is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  CounterStrikeSharp is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with CounterStrikeSharp.  If not, see <https://www.gnu.org/licenses/>. *
 */

namespace CounterStrikeSharp.API.Modules.Utils;

public class ChatColors
{
    public static char Default = '\x01';
    public static char White = '\x01';
    public static char Darkred = '\x02';
    public static char Green = '\x04';
    public static char LightYellow = '\x09';
    public static char LightBlue = '\x0B';
    public static char Olive = '\x05';
    public static char Lime = '\x06';
    public static char Red = '\x07';
    public static char LightPurple = '\x03';
    public static char Purple = '\x0E';
    public static char Grey = '\x08';
    public static char Yellow = '\x09';
    public static char Gold = '\x10';
    public static char Silver = '\x0A';
    public static char Blue = '\x0B';
    public static char DarkBlue = '\x0C';
    public static char BlueGrey = '\x0A';
    public static char Magenta = '\x0E';
    public static char LightRed = '\x0F';
    public static char Orange = '\x10';

    public static string Filter( string buffer )
    {    
        if (buffer.Contains("{white}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{white}", ChatColors.White.ToString());
    
        if (buffer.Contains("{default}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{default}", ChatColors.White.ToString());
    
        if (buffer.Contains("{darkred}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{darkred}", ChatColors.Darkred.ToString());
    
        if (buffer.Contains("{green}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{green}", ChatColors.Green.ToString());
    
        if (buffer.Contains("{lightyellow}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{lightyellow}", ChatColors.LightYellow.ToString());
    
        if (buffer.Contains("{lightblue}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{lightblue}", ChatColors.LightBlue.ToString());
    
        if (buffer.Contains("{olive}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{olive}", ChatColors.Olive.ToString());
    
        if (buffer.Contains("{lime}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{lime}", ChatColors.Lime.ToString());
    
        if (buffer.Contains("{red}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{red}", ChatColors.Red.ToString());
    
        if (buffer.Contains("{lightpurple}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{lightpurple}", ChatColors.LightPurple.ToString());
    
        if (buffer.Contains("{purple}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{purple}", ChatColors.Purple.ToString());
    
        if (buffer.Contains("{grey}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{grey}", ChatColors.Grey.ToString());
    
        if (buffer.Contains("{yellow}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{yellow}", ChatColors.Yellow.ToString());
    
        if (buffer.Contains("{gold}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{gold}", ChatColors.Gold.ToString());
    
        if (buffer.Contains("{silver}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{silver}", ChatColors.Silver.ToString());
    
        if (buffer.Contains("{blue}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{blue}", ChatColors.Blue.ToString());
    
        if (buffer.Contains("{darkblue}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{darkblue}", ChatColors.DarkBlue.ToString());
    
        if (buffer.Contains("{bluegrey}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{bluegrey}", ChatColors.BlueGrey.ToString());
    
        if (buffer.Contains("{magenta}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{magenta}", ChatColors.Magenta.ToString());
    
        if (buffer.Contains("{lightred}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{lightred}", ChatColors.LightRed.ToString());
    
        if (buffer.Contains("{orange}", StringComparison.OrdinalIgnoreCase))
            buffer = buffer.Replace("{orange}", ChatColors.Orange.ToString());
    
        return buffer;
    }
}
