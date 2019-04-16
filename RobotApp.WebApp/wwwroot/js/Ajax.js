function GetChoresList() {
    var choresList = [];
    $('.choresList').find('input[type=checkbox]:checked').each(function () {
        choresList.push($(this).val());
    });  
    return choresList;
}
//TODO: update and create in one call
function CreateRobot(robotInfo) {
    var choresList = GetChoresList();
    $.ajax({
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        type: 'POST',
        url: '/Home/CreateRobot/',
        data: JSON.stringify(robotInfo),
        success: async function (response) {
            if (response.success) {
                //TODO: update notifications to say task not task id and show robot name
                $.notify("Robot Created", "success");
                await PerformChores(choresList, response.robotId);
            } else {
                $.notify("Something Went Wrong");
            }
        },
        error: function (response) {
            $.notify("Something Went Wrong");
        }
    });
}
function UpdateRobot(robotInfo) {
    $.ajax({
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        type: 'POST',
        url: '/Robot/UpdateRobot/',
        data: JSON.stringify(robotInfo),
        success: async function (response) {
            if (response.success) {
                location.reload();
            } else {
                $.notify("Something Went Wrong");
            }
        },
        error: function (result) {
            $.notify("Something Went Wrong");
        }
    });
}
async function PerformChores(choresList, robotId) {
    //https://codeburst.io/javascript-async-await-with-foreach-b6ba62bbf404
    const start = async () => {
        await asyncForEach(choresList, async (chore) => {
            $.notify("Starting Chore: " + chore, "info");
            var response = await $.ajax({
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                type: 'POST',
                url: '/Home/PerformChore/',
                data: JSON.stringify({ ChoreID: chore, RobotID: robotId })
            });
            if (response.choreCompletedSuccessfully) {
                $.notify("Chore Completed: " + response.taskCompletedID, "success");
            } else {
                $.notify("Something went wrong performing task");
            }
        });
    };

    start();

    async function asyncForEach(array, callback) {
        for (let index = 0; index < array.length; index++) {
            await callback(array[index], index, array);
        }
    }
}

