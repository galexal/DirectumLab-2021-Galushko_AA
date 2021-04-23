import * as React from 'react';
import './result.css';

interface Props {
    users: Array<{userName: string, vote?: string}>;
}

const Result: React.FC<Props> = ({
  users
}) => {
  return (
    <div className="result">
    <div className="circle">
      <p className="number-of-players">{users.length}</p>
      <p className="voted">voted.</p>
      <p className="avg">Avg: {
       function GetAvg () {
           var sum=0;
            users.map((user) =>
            {
                if (user.vote != undefined){
                sum+=parseInt(user.vote);
                }
            })
            return sum/users.length;
        }
   }</p> 
    </div>
    <div className="valueresults">
        {users.map((user =>
            <div className="value">
            <div className="value_general">
            <p className="value_mark-yellow"></p>
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
