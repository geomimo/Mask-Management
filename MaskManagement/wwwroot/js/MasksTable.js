function addMask(id) {

    var q = parseInt(document.getElementById(id).value);
    var table = document.getElementById("selectedMasksTable");
    var exists = false;

    //If exists, add quantities
    for (i = 1; i < table.rows.length-1; i++) {
        var oCells = table.rows.item(i).cells;
        let idcell = oCells.item(0);
        if (idcell != null && idcell.innerHTML.trim() == id) {
            let newq = q + parseInt(oCells.item(1).innerHTML);
            oCells.item(1).innerHTML = newq;
            exists = true;
            break;
        }
    }
    //otherwise
    if (!exists) {
        var tr = table.insertRow(1);
        tr = table.insertRow(1);
        var td = document.createElement('td'); // table definition.

        td1 = tr.insertCell(0);
        td1.innerHTML = id;
        td2 = tr.insertCell(1);
        td2.innerHTML = q;
        td3 = tr.insertCell(2);
        td3.innerHTML = "<a class='btn btn-danger text-dark' onclick='removeMask(this)'><i class='fa fa-trash' aria-hidden='true'></i></a>";
    }

}

function removeMask(btn) {
    var row = btn.parentNode.parentNode;
    row.parentNode.removeChild(row);
}

function loadData() {
    var table = document.getElementById("selectedMasksTable");
    var hidden = document.getElementById("selectedMasks");

    var obj = {};
    for (i = 1; i < table.rows.length; i++) {

        var oCells = table.rows.item(i).cells;
        if (oCells.item(0) != null) {
            let maskId = oCells.item(0).innerHTML;
            let q = oCells.item(1).innerHTML;
            obj[maskId] = q;
        }
    }
    var data = JSON.stringify(obj);
    hidden.value = data;
}