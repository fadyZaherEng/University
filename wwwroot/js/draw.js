function display() {
    document.write("<table border='2' class='container'>")
        for (var row = 0; row < 5; row++) {
            document.write("<tr>");
        for (var col = 0; col < 5; col++) {
            document.write("<td>" + row + "," + col + "</td>");
        }
        document.write("</tr>");
        }
    document.write("</table>");
}

