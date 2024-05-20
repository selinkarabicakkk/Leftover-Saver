import React from 'react';
import Logo from '../../Assets/images/AppLogo.jpg';
import { Link } from 'react-router-dom';


import './Header.css'; 

const Header = () => {
    return (
            <div className="header">
                <img className="logo" src={Logo} alt="Logo" />
                <div className='exceptLogo'>

                    <div className='leftdiv'>
                        <Link to="/consumer"><span className='consumer'>Consumer</span></Link>
                        <Link to="/business"><span className='business'>Business</span></Link>
                    </div>

                    <div className='rightdiv'>
                        <Link to="/business-register"><button>Register Your Business</button></Link>
                        <button>Download the App</button>
                    </div>

                </div>
            </div>
    );
};
export default Header; 