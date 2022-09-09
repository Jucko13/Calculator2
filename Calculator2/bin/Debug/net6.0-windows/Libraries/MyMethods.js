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
function rgbToHsl(r, g, b){
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
}


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
function hslToRgb(h, s, l){
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
}

//From https://stackoverflow.com/questions/36098913/convert-seconds-to-days-hours-minutes-and-seconds
function printTime(seconds){ // printTime(86401.005) = "1 day, 1 second, 5 milliseconds"
	seconds = Number(seconds);
	var negative = false;
	if(seconds < 0){
		seconds = -seconds;
		negative = true;
	}
	
	var d = Math.floor(seconds / (3600*24));
	var h = Math.floor(seconds % (3600*24) / 3600);
	var m = Math.floor(seconds % 3600 / 60);
	var s = Math.floor(seconds % 60);
	var ms = (seconds % 1).toFixed(3) * 1000;
	
	var dDisplay = d > 0 ? d + (d == 1 ? " day" : " days") : "";
	var hDisplay = h > 0 ? h + (h == 1 ? " hour" : " hours") : "";
	var mDisplay = m > 0 ? m + (m == 1 ? " minute" : " minutes") : "";
	var sDisplay = s > 0 ? s + (s == 1 ? " second" : " seconds") : "";
	var msDisplay = ms > 0 ? ms + (ms == 1 ? " millisecond" : " milliseconds") : "";
	
	return (negative ? "-" : "") + [dDisplay, hDisplay, mDisplay, sDisplay, msDisplay].filter(x => x.length > 0).join(", ");
}

function timeDifference(time1, time2){ //timeDifference("22:11:22", "05:33:44") = "16:37:38"
    var timespan = new Date(time1) - new Date(time2);
    return (timespan < TimeSpan.Zero ? '-' : '') + timespan.toString("hh\\:mm\\:ss");
}