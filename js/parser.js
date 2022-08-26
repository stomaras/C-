
$.ajax({
    type:"GET",
    url: "data.json",
    datatype:"json"
}).done((data) => StartApp(data)).fail((console.error("Error Happens")))

function StartApp(data){
    console.log(data);

}