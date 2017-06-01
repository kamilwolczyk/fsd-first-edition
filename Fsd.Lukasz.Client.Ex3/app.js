var app = {};
var colors = ['#000000', '#444444', '#666666', '#999999', '#cccccc', '#eeeeee', '#f3f3f3', '#ffffff', '#ff0000', '#ff9900', '#ffff00', '#00ff00', '#00ffff', '#0000ff', '#9900ff', '#ff00ff', '#f4cccc', '#fce5cd', '#fff2cc', '#d9ead3', '#d0e0e3', '#cfe2f3', '#d9d2e9', '#ead1dc', '#ea9999', '#f9cb9c', '#ffe599', '#b6d7a8', '#a2c4c9', '#9fc5e8', '#b4a7d6', '#d5a6bd', '#e06666', '#f6b26b', '#ffd966', '#93c47d', '#76a5af', '#6fa8dc', '#8e7cc3', '#c27ba0', '#cc0000', '#e69138', '#f1c232', '#6aa84f', '#45818e', '#3d85c6', '#674ea7', '#a64d79', '#990000', '#b45f06', '#bf9000', '#38761d', '#134f5c', '#0b5394', '#351c75', '#741b47', '#660000', '#783f04', '#7f6000', '#274e13', '#0c343d', '#073763', '#20124d', '#4C1130'];

var COLOR = 'Kolor: ';

function addcolor(colorName) {
    var pallet = $('#pallet');
    pallet.find('#colorPallet').css("background-color", colorName);
    pallet.find('#colorNumber').text(COLOR + colorName);
}


(function () {
    'use strict';
    var picker = null;
    $(document).ready(function () {

        picker = $("#rowPicker");
        $.each(colors, function (i, colorName) {
            var child = $("<div></div>").css({"background-color": colorName}).addClass("col-xs-1 ").addClass("colorSquare").click(function () {
                addcolor(colorName);
            });
            picker.append(child);

        });
    });
}());
