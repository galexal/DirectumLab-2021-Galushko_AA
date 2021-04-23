import { userInfo } from 'node:os';
import * as React from 'react';
import './result.css';

interface IProps {
    users: Array<{userName: string, vote?: string}>;
    colors: Array<string>;
}

const Result: React.FC<IProps> = ({
  users,
  colors
}) => {

    const Avg = 
    function GetAvg () {
        let sum=0;
            users.map((user) =>
            {
                if (user.vote != undefined){
                sum+=parseInt(user.vote);
                }
            })
            return sum/users.length;
        }

  return (
    <div className="result">
    <div className="circle">
      <p className="number-of-players">{users.length}</p>
      <p className="voted">voted.</p>
      <p className="avg">Avg: {Avg}</p> 
    </div>
    <div className="valueresults">
        {users.map((user =>
            <div key={user.userName} className="value">
            <div className="value_general">
            <p className={colors[users.indexOf(user)]}></p>
            <p className="value_number">{user.vote}</p> 
            </div>
            <p className="value_share">{100/users.length}% (1 player)</p> 
        </div>
            ))}
    </div>
  </div>
  );
};

export default Result;
