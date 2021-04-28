import * as React from 'react';
import './result.css';

interface IProps {
    users: Array<{userName: string, vote: string|null}>|null;
    colors: Array<string>;
    avg:number;
}

const Result: React.FC<IProps> = ({
  users,
  colors,
  avg
}) => {

  const getColor = (index: number) => {
    return colors[index%colors.length] 
    }

  return (
    <div className="result">
    <div className="circle">
      <p className="number-of-players">{users ? users.length : 0}</p>
      <p className="voted">voted.</p>
      <p className="avg">AVG: {avg}</p> 
    </div>
    <div className="valueresults">
        {users && users.map((user, index) =>
            <div key={user.userName} className="value">
            <div className="value_general">
            <p className={getColor(index)}></p>
            <p className="value_number">{user.vote}</p> 
            </div>
            <p className="value_share">{
            users &&
            100/users.length}% (1 player)</p> 
        </div>
            )}
    </div>
  </div>
  );
};

export default Result;
