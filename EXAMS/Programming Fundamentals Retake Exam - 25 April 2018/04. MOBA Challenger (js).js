function moba(arr) {
    let players = {};

    for (let line of arr) {
        if (line !== 'Season end')
        {
            if (line.includes(' -> ') && line.split(' -> ').length === 3)
            {
                let [player, position, skill] = line.split(' -> ');

                if (!players.hasOwnProperty(player))
                {
                    players[player] = { [position]: Number(skill) };
                }
                else if (!players[player].hasOwnProperty(position) ||
                    players[player][position] < Number(skill))
                {
                    players[player][position] = Number(skill);
                }
            }
            else if (line.includes(' vs ') && line.split(' vs ').length === 2)
            {
                let [playerOne, playerTwo] = line.split(' vs ');

                if (players.hasOwnProperty(playerOne) && players.hasOwnProperty(playerTwo))
                {
                    let positionsOne = Object.keys(players[playerOne]);
                    for (let key of positionsOne) {
                        if (players[playerTwo].hasOwnProperty(key))
                        {
                            let totalSkillOne = Object.values(players[playerOne]).reduce((a,b) => a+b);
                            let totalSkillTwo = Object.values(players[playerTwo]).reduce((a,b) => a+b);

                            if (totalSkillOne > totalSkillTwo)
                            {
                                delete players[playerTwo];
                                break;
                            }
                            else
                            {
                                delete players[playerOne];
                                break;
                            }
                        }
                    }
                }
            }
        }
        else break;
    }

    for (let pl of Array.from(Object.keys(players)).sort((a,b) => {
        return Array.from(Object.values(players[b])).reduce((a,b) => a+b) -
            Array.from(Object.values(players[a])).reduce((a,b) => a+b);
    })) {
        console.log(`${pl}: ${Array.from(Object.values(players[pl])).reduce((a,b) => a+b)} skill`);

        for (let pos of Array.from(Object.keys(players[pl])).sort((a, b) => {
            return players[pl][b] - players[pl][a];
        })) {
            console.log(`- ${pos} <::> ${players[pl][pos]}`);
        }
    }
}