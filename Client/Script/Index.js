let app = document.getElementById("app")
let driverCount = 0
let drivers = JSON.parse(localStorage.getItem('myDrivers')) ? JSON.parse(localStorage.getItem('myDrivers')) : []
//  [
//     {
//         id: "empty id",
//         Name: "empty name",
//         Rating: "empty rating",
//         dateHired: "empty date hired",
//         deleted: "empty delted"
//     }
// ]

// let storedValues = JSON.stringify(drivers)
// localStorage.setItem('drivers',storedValues)

// console.log(drivers)
// console.log(storedValues)

// let myDrivers = localStorage.getItem('myDrivers')
// console.log(myDrivers)

// let jsonDrivers = JSON.parse(myDrivers)
// console.log(jsonDrivers)

function getDriver(){
    const driverApiUrl = "";//////where to put url for website but i think it comes from workbench mySQL

    fetch(driverApiUrl).then(function(response){
        console.log(response);
        return response.json();
    }).then(function(json){
        let html = `<table style =\"width:100%\">`
        html += "<tr><th>id</th><th>name</th><th>rating</th><th>dateHired</th><th>deleted</th></tr>"
        json.forEach((driver)=>{
            html += `<tr key =${driver.id}> <td>" +driver.name + "</td><td>" +driver.rating + "</td><td>" + driver.dateHired + "</td><td>" + driver.deleted + "</td>" + "<td> <button onClick = \"removeDriver("+driver.id+")\">Delete<\button></td>/tr>`; ////////////
        });
        html += "</table>";
        document.getElementById("drivers").innerHTML = html;
    }).catch(fucntion(error){
        console.log(error);
    });
}


function handleOnLoad(){
    createTable()
    createForm()
    createDriverTable()
}

let categories =[];
const url = ''   ////////////////////////what should I call, the mySQL?
const body = document.getElementById('root');
let table = document.createElement('table');
let thead = document.createElement('thead');
table.appendChild(thead);

function createDriverTable(){
    //get Driver Table
    fetch(url).then(function(response){
        console.log(response)
        return response.json()
    }).then(function(json){
        console.log(json)
        cate//////////////////////////////
        //Display Driver Table
        displayDriverTable(json)
    })
}

function createHeader(){
    let tr = document.createElement('tr');
    let array = ['ID', 'Description', 'Percent']

    array.forEach((heading) => {
        let th = document.createElement('th');
        th.appendChild(document.createTextNode(heading));
        tr.appendChild(th);
    })
    thead.appendChild(tr);
    body.appendChild(table);
}

function createBody(){
    categories.forEach((categories) => {
    let tr = document.createElement('tr');

    let idTd = document.createElement('td');
    idTd.appendChild()
    tr.appendChild
    })
}

function displayDriverTable(driverData){ //creates table
    let table = document.createElement('TABLE')
    table.border = '1'
    table.id = 'toDoTable'
    let tableBody = document.createElement('TBODY')
    tableBody.id = 'toDoTableBody'
    table.appendChild(tableBody)

    let tr = document.createElement('TR')
    tableBody.appendChild(tr)

    let th1 = document.createElement('TH')
    th1.width = 500
    th1.appendChild(document.createTextNode('ID'))
    tr.appendChild(th1)

    let th2 = document.createElement('TH')
    th2.width = 200
    th2.appendChild(document.createTextNode('Driver Name'))
    tr.appendChild(th2)

    let th3 = document.createElement('TH')
    th1.width = 500
    th1.appendChild(document.createTextNode('Rating'))
    tr.appendChild(th3)

    let th4 = document.createElement('TH')
    th1.width = 500
    th1.appendChild(document.createTextNode('Date Hired'))
    tr.appendChild(th4)

    let th5 = document.createElement('TH')
    th1.width = 500
    th1.appendChild(document.createTextNode('Deleted'))
    tr.appendChild(th5)

    //add data rows
    driverData.forEach((driver) => {
        let tr = document.createElement('TR')
        tableBody.appendChild(tr)

        let td1 = document.createElement('TD')
        td1.width = 500
        td1.appendChild(document.createTextNode('${driver.name}'))
        tr.appendChild(td1)

        let th2 = document.createElement('TH')
        th2.width = 200
        th2.appendChild(document.createTextNode('driver.rating'))
        tr.appendChild(th2)

        let th3 = document.createElement('TH')
        th3.width = 200
        th3.appendChild(document.createTextNode('driver.dateHired'))
        tr.appendChild(th3)
    })

    app.appendChild(table)
}

function createForm(){
    let form = document.createElement('form')
    let textInput = document.createElement('input')
    textInput.type = 'text'
    textInput.placeholder = 'Please enter a...'
    textInput.id = 'newToDo'
    form.appendChild(textInput)

    let sumbitButton = document.createElement('button')
    sumbitButton.textContent = 'Sumbit'
    form.appendChild(sumbitButton)

    form.addEventListener('submit', function(e){
        e.preventDefault()
        let currentDate = new Date().toJSON().slice(0,10)
        let toDo = {
            todo: e.target.elements.newToDo.value,
            date: currentDate
        }
        addRow(todo)
        e.target.elements.newDriver.value = ' '
    })

    app.appendChild(form)

}

function addRow(toDo){
    let tableBody = document.getElementById('toDoTableBody')
    let tr = document.createElement('TR')
    tableBody.appendChild(tr)

    let td1 = document.createElement('TD')
    td1.width = 500
    td1.appendChild(document.createTextNode('To Do'))
    tr.appendChild(td1)

    let th2 = document.createElement('TH')
    th2.width = 200
    th2.appendChild(document.createTextNode('Date'))
    tr.appendChild(th2)

    drivers.push(driver)
    localStorage.setItem('myDrivers', JSON.stringify(drivers))
}

function createTable(){ //creates table
    let table = document.createElement('TABLE')
    table.border = '1'
    table.id = 'toDoTable'
    let tableBody = document.createElement('TBODY')
    tableBody.id = 'toDoTableBody'
    table.appendChild(tableBody)

    let tr = document.createElement('TR')
    tableBody.appendChild(tr)

    let th1 = document.createElement('TH')
    th1.width = 500
    th1.appendChild(document.createTextNode('To Do'))
    tr.appendChild(th1)

    let th2 = document.createElement('TH')
    th2.width = 200
    th2.appendChild(document.createTextNode('To Do'))
    tr.appendChild(th2)

    //add data rows
    toDos.forEach((toDo) => {
        let tr = document.createElement('TR')
        tableBody.appendChild(tr)

        let td1 = document.createElement('TD')
        td1.width = 500
        td1.appendChild(document.createTextNode('To Do'))
        tr.appendChild(td1)

        let th2 = document.createElement('TH')
        th2.width = 200
        th2.appendChild(document.createTextNode('Date'))
        tr.appendChild(th2)
    })

    app.appendChild(table)
}