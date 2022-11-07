
var Lib = {
    /**
     * From https://stackoverflow.com/questions/2353211/hsl-to-rgb-color-conversion
     * Converts an RGB color value to HSL. Conversion formula
     * adapted from http://en.wikipedia.org/wiki/HSL_color_space.
     * Assumes r, g, and b are contained in the set [0, 255] and
     * returns h, s, and l in the set [0, 1].
     *
     * @param   {number}  r       The red color value
     * @param   {number}  g       The green color value
     * @param   {number}  b       The blue color value
     * @return  {Array}           The HSL representation
     */
    rgbToHsl: function(r, g, b){
        r /= 255, g /= 255, b /= 255;
        var max = Math.max(r, g, b), min = Math.min(r, g, b);
        var h, s, l = (max + min) / 2;

        if(max == min){
            h = s = 0; // achromatic
        }else{
            var d = max - min;
            s = l > 0.5 ? d / (2 - max - min) : d / (max + min);
            switch(max){
                case r: h = (g - b) / d + (g < b ? 6 : 0); break;
                case g: h = (b - r) / d + 2; break;
                case b: h = (r - g) / d + 4; break;
            }
            h /= 6;
        }

        return [h, s, l];
    },

    /**
     * Converts an HSL color value to RGB. Conversion formula
     * adapted from http://en.wikipedia.org/wiki/HSL_color_space.
     * Assumes h, s, and l are contained in the set [0, 1] and
     * returns r, g, and b in the set [0, 255].
     *
     * @param   {number}  h       The hue
     * @param   {number}  s       The saturation
     * @param   {number}  l       The lightness
     * @return  {Array}           The RGB representation
     */
    hslToRgb: function(h, s, l){
        var r, g, b;

        if(s == 0){
            r = g = b = l; // achromatic
        }else{
            var hue2rgb = function hue2rgb(p, q, t){
                if(t < 0) t += 1;
                if(t > 1) t -= 1;
                if(t < 1/6) return p + (q - p) * 6 * t;
                if(t < 1/2) return q;
                if(t < 2/3) return p + (q - p) * (2/3 - t) * 6;
                return p;
            }

            var q = l < 0.5 ? l * (1 + s) : l + s - l * s;
            var p = 2 * l - q;
            r = hue2rgb(p, q, h + 1/3);
            g = hue2rgb(p, q, h);
            b = hue2rgb(p, q, h - 1/3);
        }

        return [Math.round(r * 255), Math.round(g * 255), Math.round(b * 255)];
    },

    pickColor: function (initialColor){
        colorPicker.Color         = initialColor ?? colorPicker.Color;
        colorPicker.AllowFullOpen = true;
        colorPicker.AnyColor      = true;
        colorPicker.FullOpen      = true;
        colorPicker.ShowDialog();
        
        var colorVariants = "Color.FromArgb(" + colorPicker.Color.R + ", " + colorPicker.Color.G + ", " + colorPicker.Color.B + ");";
        colorVariants += " | " + this.rgbToHex(colorPicker.Color.R,colorPicker.Color.G,colorPicker.Color.B);
        colorVariants += " | " + colorPicker.Color.R + "; " + colorPicker.Color.G + "; " + colorPicker.Color.B;
        
        return colorVariants;
    },

    rgbToHex: function (r, g, b){
        return "#" + r.toString(16).padStart(2, '0') + g.toString(16).padStart(2, '0') + b.toString(16).padStart(2, '0');
    },

    //From https://stackoverflow.com/questions/36098913/convert-seconds-to-days-hours-minutes-and-seconds
    printTime: function(seconds){ // printTime(86401.005366) = "1 day, 1 second, 5 milliseconds, 366 microseconds"
        seconds = Number(seconds);
        var negative = false;
        if(seconds < 0){
            seconds = -seconds;
            negative = true;
        }
        
        var d  = Math.floor(seconds / (3600*24));
        var h  = Math.floor(seconds % (3600*24) / 3600);
        var m  = Math.floor(seconds % 3600 / 60);
        var s  = Math.floor(seconds % 60);
        var ms = (seconds % 1).toFixed(3) * 1000;
        var us = ((seconds*1000) % 1).toFixed(6) * 1000;
        
        var dDisplay  = d > 0 ? d + (d == 1 ? " day" : " days") : "";
        var hDisplay  = h > 0 ? h + (h == 1 ? " hour" : " hours") : "";
        var mDisplay  = m > 0 ? m + (m == 1 ? " minute" : " minutes") : "";
        var sDisplay  = s > 0 ? s + (s == 1 ? " second" : " seconds") : "";
        var msDisplay = ms > 0 ? ms + (ms == 1 ? " millisecond" : " milliseconds") : "";
        var usDisplay = us > 0 ? us + (us == 1 ? " microsecond" : " microseconds") : "";
                
        return (negative ? "-" : "") + [dDisplay, hDisplay, mDisplay, sDisplay, msDisplay, usDisplay].filter(x => x.length > 0).join(", ");
    },

    timeDifference: function(time1, time2){ //timeDifference("22:11:22", "05:33:44") = "16:37:38"
        var timespan = new Date(time1) - new Date(time2);
        return (timespan < TimeSpan.Zero ? '-' : '') + timespan.toString("hh\\:mm\\:ss");
    },
    
    Dec: function(val){
        var k    = importNamespace('Toolbox.Helper');
        return k.BigDecimal.Parse(val);
    }

};

    
var Matd = {
    sin: function(number){
        return Math.sin(degToRad(number));
    },
    cos: function(number){
        return Math.cos(degToRad(number));
    },
    tan: function(number){
        return Math.tan(degToRad(number));
    },
    asin: function(number){
        return radToDeg(Math.asin(number));
    },
    acos: function(number){
       return radToDeg(Math.acos(number));
    },
    atan: function(number){
       return radToDeg(Math.atan(number));
    }
};

var Mate = {
 
    radToDeg: function(angle){
        return angle / Math.PI * 180;
    },
    degToRad: function (angle){
        return angle / 180 * Math.PI;
    },
    logB: function (base, log){
        return Math.log(log) / Math.log(base);
    }
};

var PLC = {
    convertTime: function (inputtime){
        var hundredsSeconds = (inputtime & 0xff); //1/100th of a second
        var seconds         = ((inputtime >> 8) & 0xff);
        var minutes         = ((inputtime >> 16) & 0xff);
        var hours           = ((inputtime >> 24) & 0xff);
        
        return hours + ":" + minutes + ":" + seconds + "." + hundredsSeconds;
    },
    srvNameToText: function(inp){
        var inp = inp || Clipboard.GetText();
        var res = inp.substring(3).replace(/[A-Z]/g, ' $&').trim().toLowerCase();
        res     = res.charAt(0).toUpperCase() + res.substring(1);
        Clipboard.Clear();
        Clipboard.SetText(res);
        return res;
    }
};

//importNamespace('System.Numerics');

//big = (intString1) => new BigInt(intString1);

//This method may not be removed, it is used by the json stringify method to parse 
//objects to a string to print in the output window. Removing this breaks the calculator
function stringifyReplacer (k, v) {
    if (typeof v === 'BigDecimal') {
        return v.toString();
    }
    return v;
}