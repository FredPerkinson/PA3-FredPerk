//watched tables and forms and local storage and API Calls and MySql    
//need table to add date element probably not working because need to add more than one thing to type in insetad of just name

//need to figure out how to call the api
//need to fix using statements for MySql
//how to add rating and name do i need multiple buttons?



let app = document.getElementById("app")
let taskcount = 0  
let drivers = JSON.parse(localStorage.getItem('drivers')) ? JSON.parse(localStorage.getItem('drivers')) : []

function handleOnLoad(){
    createTable()
    createFrom()
    createDriverTable()
}

function createDriverTable(){

    const url = 'https://dashboard.heroku.com/apps/pa3-fredp'   ////////////heroku database url???
    fetch(url).then(function(response){
        console.log(response)
        return response.json()
    }).then(function(json){
        console.log(json)
        displayDriverTable(json)
    })
}

function displayDriverTable(driverData){
    let table = document.createElement('TABLE')
    table.border = '1'
    table.id = 'DriverTable'
    let tableBody = document.createElement('TBODY')
    tableBody.id = 'DriverTableBody'
    table.appendChild(tableBody)

    let tr = document.createElement('TR')
    tableBody.appendChild(tr)

    let th1 = document.createElement('TH')
    th1.width = 100
    th1.appendChild(document.createTextNode('id'))
    tr.appendChild(th1)

    let th2 = document.createElement('TH')
    th2.width = 100
    th2.appendChild(document.createTextNode('First Name'))
    tr.appendChild(th2)

    let th3 = document.createElement('TH')
    th3.width = 100
    th3.appendChild(document.createTextNode('Rating'))
    tr.appendChild(th3)

    let th4 = document.createElement('TH')
    th4.width = 100
    th4.appendChild(document.createTextNode('Date Hired'))
    tr.appendChild(th4)

    let th5 = document.createElement('TH')
    th5.width = 100
    th5.appendChild(document.createTextNode('Deleted'))
    tr.appendChild(th5)


    drivers.forEach((drivers) => {
    let tr = document.createElement('TR')
    tableBody.appendChild(tr)

    let td1 = document.createElement('TD')
    td1.width = 100
    td1.appendChild(document.createTextNode(`${drivers.id}`))
    tr.appendChild(td1)

    let td2 = document.createElement('TD')
    td2.width = 100
    td2.appendChild(document.createTextNode(`${drivers.firstName}`))
    tr.appendChild(td2)

    let td3 = document.createElement('TD')
    td3.width = 100
    td3.appendChild(document.createTextNode(`${drivers.rating}`))
    tr.appendChild(td3)

    let td4 = document.createElement('TD')
    td4.width = 100
    td4.appendChild(document.createTextNode(`${drivers.dateHired}`))
    tr.appendChild(td4)

    let td5 = document.createElement('TD')
    td5.width = 100
    td5.appendChild(document.createTextNode(`${drivers.deleted}`))
    tr.appendChild(td5)
    })
    app.appendChild(table)
}

function createFrom(){
    let form = document.createElement('form')
    let textInput = document.createElement('input')
    textInput.type = 'text'
    textInput.placeholder = 'Please enter a Driver'
    textInput.id = 'newDriver'
    form.appendChild(textInput) 

    let sumbitButton = document.createElement('button')
    sumbitButton.textContent = 'Submit'
    form.appendChild(sumbitButton)

    form.addEventListener('submit', function(e){
        e.preventDefault()
        let currentDate = new Date().toJSON.slice(0,10)
        let driver = {
            id: e.target.elements.newdriver.value,
            firstName: e.target.elements.newdriver.value,
            rating: e.target.elements.newdriver.value,
            dateHired: currentDate,
            deleted: e.target.elements.newdriver.value
        }
        addRow(driver)
        e.target.elements.newdriver.value = ''
    })

    app.appendChild(form)
}

function addRow(driver){
    let tableBody = document.getElementById('DriverTableBody')
    let tr = document.createElement('TR')
    tableBody.appendChild(tr)

    let td1 = document.createElement('TD')
    td1.width = 100
    td1.appendChild(document.createTextNode(`${drivers.id}`))
    tr.appendChild(td1)

    let td2 = document.createElement('TD')
    td2.width = 100
    td2.appendChild(document.createTextNode(`${drivers.firstName}`))
    tr.appendChild(td2)

    let td3 = document.createElement('TD')
    td3.width = 100
    td3.appendChild(document.createTextNode(`${drivers.rating}`))
    tr.appendChild(td3)

    let td4 = document.createElement('TD')
    td4.width = 100
    td4.appendChild(document.createTextNode(`${drivers.dateHired}`))
    tr.appendChild(td4)

    let td5 = document.createElement('TD')
    td5.width = 100
    td5.appendChild(document.createTextNode(`${drivers.deleted}`))
    tr.appendChild(td5)

    drivers.push(drivers)

    localStorage.setItem('drivers', JSON.stringify(drivers))
}

function createTable(){
    let table = document.createElement('TABLE')
    table.border = '1'
    table.id = 'DriverTable'
    let tableBody = document.createElement('TBODY')
    tableBody.id = 'DriverTableBody'
    table.appendChild(tableBody)

    let tr = document.createElement('TR')
    tableBody.appendChild(tr)

    let th1 = document.createElement('TH')
    th1.width = 100
    th1.appendChild(document.createTextNode('id'))
    tr.appendChild(th1)

    let th2 = document.createElement('TH')
    th2.width = 100
    th2.appendChild(document.createTextNode('First Name'))
    tr.appendChild(th2)

    let th3 = document.createElement('TH')
    th3.width = 100
    th3.appendChild(document.createTextNode('Rating'))
    tr.appendChild(th3)

    let th4 = document.createElement('TH')
    th4.width = 100
    th4.appendChild(document.createTextNode('Date Hired'))
    tr.appendChild(th4)

    let th5 = document.createElement('TH')
    th5.width = 100
    th5.appendChild(document.createTextNode('Deleted'))
    tr.appendChild(th5)


    drivers.forEach((drivers) => {
    let tr = document.createElement('TR')
    tableBody.appendChild(tr)

    let td1 = document.createElement('TD')
    td1.width = 100
    td1.appendChild(document.createTextNode(`${drivers.id}`))
    tr.appendChild(td1)

    let td2 = document.createElement('TD')
    td2.width = 100
    td2.appendChild(document.createTextNode(`${drivers.firstName}`))
    tr.appendChild(td2)

    let td3 = document.createElement('TD')
    td3.width = 100
    td3.appendChild(document.createTextNode(`${drivers.rating}`))
    tr.appendChild(td3)

    let td4 = document.createElement('TD')
    td4.width = 100
    td4.appendChild(document.createTextNode(`${drivers.dateHired}`))
    tr.appendChild(td4)

    let td5 = document.createElement('TD')
    td5.width = 100
    td5.appendChild(document.createTextNode(`${drivers.deleted}`))
    tr.appendChild(td5)
    })
    app.appendChild(table)
}




//let app = document.getElementById("app")
// let driverCount = 0
// let drivers = JSON.parse(localStorage.getItem('myDrivers')) ? JSON.parse(localStorage.getItem('myDrivers')) : []
// //  [
// //     {
// //         id: "empty id",
// //         Name: "empty name",
// //         Rating: "empty rating",
// //         dateHired: "empty date hired",
// //         deleted: "empty delted"
// //     }
// // ]

// // let storedValues = JSON.stringify(drivers)
// // localStorage.setItem('drivers',storedValues)

// // console.log(drivers)
// // console.log(storedValues)

// // let myDrivers = localStorage.getItem('myDrivers')
// // console.log(myDrivers)

// // let jsonDrivers = JSON.parse(myDrivers)
// // console.log(jsonDrivers)

// function getDriver(){
//     const driverApiUrl = "https://dashboard.heroku.com/apps/pa3-fredp/api/drivers";

//     fetch(driverApiUrl).then(function(response){
//         console.log(response);
//         return response.json();
//     }).then(function(json){
//         let html = `<table style =\"width:100%\">`
//         html += "<tr><th>id</th><th>name</th><th>rating</th><th>dateHired</th><th>deleted</th></tr>"
//         json.forEach((driver)=>{
//             html += "<tr key = " + driver.id + "> <td> " + driver.name + "</td><td>" +driver.rating + "</td><td>" + driver.dateHired + "</td><td>" + driver.deleted + "</td>" + "<td> <button onClick = \"showModal("driver.id",\'") ///////////do this with $(driver.id)
            
//             removeDriver("+driver.id+")\">Delete<\button></td>/tr>;
//         });
//         html += "</table>";
//         document.getElementById("drivers").innerHTML = html;
//     }).catch(function(error){
//         console.log(error);
//     });
// }


// function handleOnLoad(){
//     createTable()
//     createForm()
//     createDriverTable()
// }

// let categories =[];
// const url = ''   ////////////////////////what should I call, the mySQL?
// const body = document.getElementById('root');
// let table = document.createElement('table');
// let thead = document.createElement('thead');
// table.appendChild(thead);

// function createDriverTable(){
//     //get Driver Table
//     fetch(url).then(function(response){
//         console.log(response)
//         return response.json()
//     }).then(function(json){
//         console.log(json)
//         cate//////////////////////////////
//         //Display Driver Table
//         displayDriverTable(json)
//     })
// }

// function createHeader(){
//     let tr = document.createElement('tr');
//     let array = ['ID', 'Description', 'Percent']

//     array.forEach((heading) => {
//         let th = document.createElement('th');
//         th.appendChild(document.createTextNode(heading));
//         tr.appendChild(th);
//     })
//     thead.appendChild(tr);
//     body.appendChild(table);
// }

// function createBody(){
//     categories.forEach((categories) => {
//     let tr = document.createElement('tr');

//     let idTd = document.createElement('td');
//     idTd.appendChild()
//     tr.appendChild
//     })
// }

// function displayDriverTable(driverData){ //creates table
//     let table = document.createElement('TABLE')
//     table.border = '1'
//     table.id = 'toDoTable'
//     let tableBody = document.createElement('TBODY')
//     tableBody.id = 'toDoTableBody'
//     table.appendChild(tableBody)

//     let tr = document.createElement('TR')
//     tableBody.appendChild(tr)

//     let th1 = document.createElement('TH')
//     th1.width = 500
//     th1.appendChild(document.createTextNode('ID'))
//     tr.appendChild(th1)

//     let th2 = document.createElement('TH')
//     th2.width = 200
//     th2.appendChild(document.createTextNode('Driver Name'))
//     tr.appendChild(th2)

//     let th3 = document.createElement('TH')
//     th1.width = 500
//     th1.appendChild(document.createTextNode('Rating'))
//     tr.appendChild(th3)

//     let th4 = document.createElement('TH')
//     th1.width = 500
//     th1.appendChild(document.createTextNode('Date Hired'))
//     tr.appendChild(th4)

//     let th5 = document.createElement('TH')
//     th1.width = 500
//     th1.appendChild(document.createTextNode('Deleted'))
//     tr.appendChild(th5)

//     //add data rows
//     driverData.forEach((driver) => {
//         let tr = document.createElement('TR')
//         tableBody.appendChild(tr)

//         let td1 = document.createElement('TD')
//         td1.width = 500
//         td1.appendChild(document.createTextNode('${driver.name}'))
//         tr.appendChild(td1)

//         let th2 = document.createElement('TH')
//         th2.width = 200
//         th2.appendChild(document.createTextNode('driver.rating'))
//         tr.appendChild(th2)

//         let th3 = document.createElement('TH')
//         th3.width = 200
//         th3.appendChild(document.createTextNode('driver.dateHired'))
//         tr.appendChild(th3)
//     })

//     app.appendChild(table)
// }

// function createForm(){
//     let form = document.createElement('form')
//     let textInput = document.createElement('input')
//     textInput.type = 'text'
//     textInput.placeholder = 'Please enter a...'
//     textInput.id = 'newToDo'
//     form.appendChild(textInput)

//     let sumbitButton = document.createElement('button')
//     sumbitButton.textContent = 'Sumbit'
//     form.appendChild(sumbitButton)

//     form.addEventListener('submit', function(e){
//         e.preventDefault()
//         let currentDate = new Date().toJSON().slice(0,10)
//         let toDo = {
//             todo: e.target.elements.newToDo.value,
//             date: currentDate
//         }
//         addRow(todo)
//         e.target.elements.newDriver.value = ' '
//     })

//     app.appendChild(form)

// }

// function addRow(toDo){
//     let tableBody = document.getElementById('toDoTableBody')
//     let tr = document.createElement('TR')
//     tableBody.appendChild(tr)

//     let td1 = document.createElement('TD')
//     td1.width = 500
//     td1.appendChild(document.createTextNode('To Do'))
//     tr.appendChild(td1)

//     let th2 = document.createElement('TH')
//     th2.width = 200
//     th2.appendChild(document.createTextNode('Date'))
//     tr.appendChild(th2)

//     drivers.push(driver)
//     localStorage.setItem('myDrivers', JSON.stringify(drivers))
// }

// function createTable(){ //creates table
//     let table = document.createElement('TABLE')
//     table.border = '1'
//     table.id = 'toDoTable'
//     let tableBody = document.createElement('TBODY')
//     tableBody.id = 'toDoTableBody'
//     table.appendChild(tableBody)

//     let tr = document.createElement('TR')
//     tableBody.appendChild(tr)

//     let th1 = document.createElement('TH')
//     th1.width = 500
//     th1.appendChild(document.createTextNode('To Do'))
//     tr.appendChild(th1)

//     let th2 = document.createElement('TH')
//     th2.width = 200
//     th2.appendChild(document.createTextNode('To Do'))
//     tr.appendChild(th2)

//     //add data rows
//     toDos.forEach((toDo) => {
//         let tr = document.createElement('TR')
//         tableBody.appendChild(tr)

//         let td1 = document.createElement('TD')
//         td1.width = 500
//         td1.appendChild(document.createTextNode('To Do'))
//         tr.appendChild(td1)

//         let th2 = document.createElement('TH')
//         th2.width = 200
//         th2.appendChild(document.createTextNode('Date'))
//         tr.appendChild(th2)
//     })

//     app.appendChild(table)


//     function postDriver(){
//         const postDriverApiUrl = "";

//         const driverid = document.getElementById("id").myDriver;
//         const driverfirstName = document.getElementById("firstName").myDriver;
//         const driverrating = document.getElementById("rating").myDriver;
//         const driverdateHired = document.getElementById("dateHired").myDriver;
//         const driverdeleted = document.getElementById("deleted").myDriver;

//         fetch(postDriverApiUrl, {
//             method: "POST" ,
//             headers: {
//                 "Accept": 'application/json',
//                 "Content-Type": 'application/json', 
//             },
//             body: JSON.stringify({
//                 id: driverid,
//                 firstName: driverfirstName,
                
//             })
//             }
//         })

//     }
// }