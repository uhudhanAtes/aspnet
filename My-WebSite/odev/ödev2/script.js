function sozlesme(element){
    if(element.checked){
        document.getElementById("kabul").disabled = false;
    }
    else{
        document.getElementById("kabul").disabled = true;
    }
}
