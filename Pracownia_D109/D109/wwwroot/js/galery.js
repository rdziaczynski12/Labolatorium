var bigImage = document.querySelector('.bigImage > img');

var miniImg = document.querySelector('.miniImg');

miniImg.onclick = function (e) {
    e = e || window.event;
    var target = e.target || e.srcElement;

    while (target != this) {

        if (target.nodeName == 'A') {
            DisplayMini(target.href, target.title);
            return false;
        }

        target = target.parentNode;
    }
}

function DisplayMini(href, title) {
    bigImage.src = href;
    bigImage.alt = title;
}

var imgs = miniImg.getElementsByTagName('img');

for (var i = 0; i < imgs.length; i++) {
    var url = imgs[i].parentNode.href;
    var img = document.createElement('img');
    img.src = url;
}