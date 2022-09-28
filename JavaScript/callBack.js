
orderPizza('veg', 'paneer bbq', (msg)=>{
console.log(msg)
})


function orderPizza(type, name, callback)
{
    console.log(`Prepare ${type} ${name} pizza`)
    setTimeout( ()=> {
        const msg = 'Your order is ready'
        callback(msg)
        setTimeout( () => {
            console.log("another timeout")
        }, 1000)
    }, 3000);

}

//console.log("the end")

