function GetChoresList() {
    var choresList = [];
    $('.choresList').find('input[type=checkbox]:checked').each(function () {
        var id = parseInt($(this).val());
        var name = $(this).next("label").html();
        choresList.push({ id, name });
    });
    return choresList;
}
function CreateRobot(robotInfo) {
    var choresList = GetChoresList();
    $.ajax({
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        type: 'POST',
        url: '/Home/CreateRobot/',
        data: JSON.stringify(robotInfo),
        success: async function (response) {
            $.notify(response.robotName + " created", "success", { position: "right" });
            await PerformChores(choresList, response.robotID, response.robotName);
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
async function PerformChores(choresList, robotId, robotName) {
    //sync for loop ajax call https://codeburst.io/javascript-async-await-with-foreach-b6ba62bbf404
    const start = async () => {
        await asyncForEach(choresList, async (chore) => {
            $.notify(robotName + " is starting chore: " + chore.name, "info");
            var response = await $.ajax({
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                type: 'POST',
                url: '/Home/PerformChore/',
                data: JSON.stringify({ ChoreID: chore.id, RobotID: robotId })
            });
            if (response.choreCompletedSuccessfully) {
                $.notify(response.robotName + " completed " + response.choreCompleted, "success");
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

