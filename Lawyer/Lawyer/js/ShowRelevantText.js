function ShowText(number) {
    for (var i = 1; i < 23; i++) {
        if(number == i)
            document.getElementById(number.toString()).hidden = "";
        else
            document.getElementById(number.toString()).hidden = "hidden";
    }

}