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
    const getAvg = () => {
        let sum=0;
            users.map((user) =>
            {
                if (user.vote != undefined){
                sum+=parseInt(user.vote);
                }
            })
            return sum/users.length;
        }

    const getColor = (index: number) => {
        return colors[index%colors.length] 
        }

  return (
    <div className="result">
    <div className="circle">
      <p className="number-of-players">{users.length}</p>
      <p className="voted">voted.</p>
      <p className="avg">Avg: {getAvg()}</p> 
    </div>
    <div className="valueresults">
        {users.map((user, index) =>
            <div key={user.userName} className="value">
            <div className="value_general">
            <p className={getColor(index)}></p>
            <p className="value_number">{user.vote}</p> 
            </div>
            <p className="value_share">{100/users.length}% (1 player)</p> 
        </div>
            )}
    </div>
  </div>
  );
};

export default Result;
