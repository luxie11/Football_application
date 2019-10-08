var header = document.getElementById('header');
var sidebar = document.getElementById('sidebar-wrapper');
var container = document.querySelector('.content-wrapper');
var addItemButton = document.querySelector('.add-item');

document.querySelector('.sidebar-icon').addEventListener('click', function () {
    header.classList.toggle('active-header');
    sidebar.classList.toggle('active-sidebar');
    if (window.innerWidth >= 1001) {
        if (sidebar.classList.contains('active-sidebar')) {
            container.style.width = "85%";
        } else {
            container.style.width = "100%";
        }
    } else {
        if (sidebar.classList.contains('active-sidebar')) {
            container.style.width = "70%";
        } else {
            container.style.width = "100%";
        }
    }
});

var modalElement = document.querySelector('.modal');
if (addItemButton) {
    addItemButton.addEventListener('click', function () {
        modalElement.style.display = "block";
    });
}

var closeButton = document.querySelector('.close-btn');
if (closeButton) {
    closeButton.addEventListener('click', function () {
        modalElement.style.display = "none";
    });
}


var settingsButton = document.getElementById('settings');
if (settingsButton) {
    var settingsDropdown = document.querySelector('.settings-dropdown');
    settingsButton.addEventListener('click', function () {
        settingsDropdown.classList.toggle('dropdown-active');
    })
}


window.onclick = function (e) {
    e.stopPropagation();
    if (e.target == modalElement) {
        modalElement.style.display = "none";
    }
    var settingsIcon = document.querySelector('#settings > i')
    if (e.target != settingsDropdown && !e.target.classList.contains('dropdown-item') &&
        !e.target.classList.contains('dropdown-link') && e.target != settingsButton && e.target != settingsIcon) {
        settingsDropdown.classList.remove('dropdown-active');
    }
}

var sidebarDropdownArray = document.querySelectorAll('.sidebar-item.has-child');
sidebarDropdownArray.forEach(el => {
    el.addEventListener('click', function (e) {
        e.stopPropagation();
        el.classList.toggle('active-dropdown');
        el.children[1].classList.toggle('active-child-elements');
        if (el.classList.contains('active-dropdown')) {
            el.children[0].children[1].classList.remove("fa-chevron-down");
            el.children[0].children[1].classList.add("fa-chevron-up");
        } else {
            el.children[0].children[1].classList.remove("fa-chevron-up");
            el.children[0].children[1].classList.add("fa-chevron-down");
        }
    })
})

