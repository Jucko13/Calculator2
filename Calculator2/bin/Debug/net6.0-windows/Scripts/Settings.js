
//When done changing values call LoadExtraButtons() to apply
var programButtons = [
    { 
        Text: "", //spacer
        Action: "|",
        Color : rgbToHex(30, 33, 36)
        Colspan: 6,
        TooltipText : ""
    },
    { 
        Text: "r to °",
        Action: "radToDeg(|)",
        Color : rgbToHex(15, 190, 0xe3)
        Colspan: 2,
        TooltipText : "Radians to Degrees"
    },
    { 
        Text: "° to r",
        Action: "degToRad(|)",
        Color : "#0Fbee3"
        Colspan: 2,
        TooltipText : "Degrees to Radians"
    },
    { 
        Text: "🎨", //paint swatch
        Action: "pickColor()|",
        Color : "#b300e3"
        Colspan: 1,
        TooltipText : "Opens the .Net ColorDialog"
    },
    { 
        Text: "printTime(s)", //paint swatch
        Action: "printTime(|)",
        Color : rgbToHex(15, 190, 0xe3)
        Colspan: 3,
        TooltipText : "prints seconds as timestamp"
    }
];