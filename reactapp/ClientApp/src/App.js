import React, { Component, useEffect, useState } from 'react';


const App = () => {
    const [tasks, setTask] = useState([])

    const showAllTask = async () => {
        //Request to API
        const response = awat fetch("api/task/List");
        if (res.ok) {
            const taskData = await response.json();
            setTask(taskData);

        } else {
            console.log("status code: " + response.status)
        }
    }

    //When app is loaded then run showAllTask
    useEffect(() => {
        showAllTask();
    }, [])

    console.log(tasks)


    return (
        <div className="container mx-auto">
            <table class="table-auto">
                <thead >
                    <tr>
                        {tasks.map((head) => (
                            <th key={head}>
                                <Text>{head}</Text>
                            </th>
                        ))}
                        
                    </tr>
                </thead>
                <tbody>
                    {tasks.map(({ idTask, descriptionTask, registerDate }, index => {
                        const isLast = index === tasks.length - 1;

                        return (
                            <tr key={idTask}>
                                <td >
                                    <Text className="font-normal">
                                        {idTask}
                                    </Text>
                                </td>
                                <td >
                                    <Text className="font-normal">
                                        {descriptionTask}
                                    </Text>
                                </td>
                                <td >
                                    <Text  className="font-normal">
                                        {registerDate}
                                    </Text>
                                </td>
                            </tr>

                        )

                    }))}


                </tbody>
            </table>
        </div>
    )
}

export default App;