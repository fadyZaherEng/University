function ChangeImageSize() {
    var image = document.getElementById('image');
    var newWidth = document.getElementById('width').value;
    var newHeight = document.getElementById('height').value;
    //image.style.width = newWidth + 'px';
    //image.style.height = newHeight + 'px';
    document.getElementById("image").width = newWidth;
    document.getElementById("image").height = newHeight;
    document.body.style.backgroundColor = "teal";
    //document.bgColor="blue";
}
