
var rowNumber = 700;
var columnNumber = 450;
var k = 1;
for (var i = 1; i <= 5; i++) {

    for (var j = 1; j <= 6; j++) {

        var aLink = document.createElement('a');
        aLink.href = '/Product/Index';
        aLink.style = 'color:black;';
        
        var mainCon = document.getElementById("Main-Container");

        mainCon.appendChild(aLink);

        var boxDiv = document.createElement('button');
        boxDiv.className = "reservation-table";
        boxDiv.id='table'+k;
     
        boxDiv.onclick = TableStatusColor(this);
      
        aLink.appendChild(boxDiv);

        var numberDiv = document.createElement('div');
        numberDiv.className = "table-number";
        numberDiv.textContent = k;
        k = k + 1;
        boxDiv.appendChild(numberDiv);

        boxDiv.style = 'left:' + columnNumber + 'px; top:' + rowNumber + 'px;';
        columnNumber = columnNumber + 70;
    }

    rowNumber = rowNumber + 70;

    columnNumber = 450;
}

function TableStatusColor(el) {
    debugger;
    el.style="background-color:red";
}