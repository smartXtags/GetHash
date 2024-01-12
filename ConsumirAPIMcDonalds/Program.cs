using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

Console.Write("Insira um valor para transformar em Hash: ");
string input = Console.ReadLine();
using var sha256 = SHA256.Create();
var bytes = Encoding.UTF8.GetBytes(input);
var hashBytes = sha256.ComputeHash(bytes);

var verify = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

Console.WriteLine("Meu string criptografado: " + verify);