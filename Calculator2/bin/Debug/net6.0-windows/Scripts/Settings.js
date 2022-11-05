
//When done changing values call LoadExtraButtons() to apply
var programButtons = [
    /*{ 
        Text: "", //spacer
        Action: "|",
        Color : rgbToHex(30, 33, 36),
        Colspan: 2,
        TooltipText : ""
    },*/
    { 
        Text: "[].hex",
        Action: ".hex(|)",
        Color : Lib.rgbToHex(67, 181, 129),
        Colspan: 2,
        TooltipText : "Converts number array to string hex array [10, 15, 99].hex(2, \"0x\") = [\"0x0a\",\"0x0f\",\"0x63\"]"
    },
    { 
        Text: "printTime(s)", //paint swatch
        Action: "Lib.printTime(|)",
        Color : Lib.rgbToHex(15, 190, 0xe3),
        Colspan: 4,
        TooltipText : "prints seconds as timestamp (86401.005366) = \"1 day, 1 second, 5 milliseconds, 366 microseconds\""
    },
    { 
        Text: "timeDifference(t1,t2)", //paint swatch
        Action: "Lib.timeDifference(|,)",
        Color : Lib.rgbToHex(15, 190, 0xe3),
        Colspan: 6,
        TooltipText : "prints the difference of two timestamp strings (\"22:11:22\", \"05:33:44\") = \"16:37:38\""
    },
    { 
        Text: "logB",
        Action: "Mate.logB(|,)",
        Color : Lib.rgbToHex(250, 166, 26),
        Colspan: 2,
        TooltipText : "Log with custom Base (base, log)"
    },
    { 
        Text: "r to °",
        Action: "Mate.radToDeg(|)",
        Color : Lib.rgbToHex(15, 190, 0xe3),
        Colspan: 2,
        TooltipText : "Radians to Degrees"
    },
    { 
        Text: "° to r",
        Action: "Mate.degToRad(|)",
        Color : "#0Fbee3",
        Colspan: 2,
        TooltipText : "Degrees to Radians"
    },
    { 
        Text: "🎨", //paint swatch
        Action: "Lib.pickColor()|",
        Color : Lib.rgbToHex(15, 190, 0xe3),
        Colspan: 1,
        TooltipText : "Opens the .Net ColorDialog"
    },
    { 
        Text: "[,]",
        Action: "[|,]",
        Color : Lib.rgbToHex(67, 181, 129),
        Colspan: 2,
        TooltipText : "Encapsulates the selection in brackets and adds a coma"
    }
];