using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace SelfOrderSystem.Services;
public static class SessionExtensions {
    public static void SetObject<T>(this ISession session, string key, T value) {
        string json = JsonSerializer.Serialize(value);           // C#オブジェクトをJSON化 
        session.SetString(key, json);                             // Sessionへ保存 
    }

    public static T? GetObject<T>(this ISession session, string key) {
        string? json = session.GetString(key);                    // JSONを取得 
        if (string.IsNullOrEmpty(json)) {
            return default;
        }
        return JsonSerializer.Deserialize<T>(json);              // C#オブジェクトへ戻す 
    }
}

